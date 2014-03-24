using BztErrorsManager.Client.Commands;
using BztErrorsManager.Client.Constantes;
using BztErrorsManager.Client.Utility;
using BztErrorsManager.Model.ModelBzt;
using BztErrorsManager.Model.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;

namespace BztErrorsManager.Client
{
	public class MainViewModel : INotifyPropertyChanged, INotifyPropertyChanging
	{
		private const string FaultCodeAll = "<All>";
		private IEnumerable<string> _selectedFaultCodes;
		
		private EsbExceptionDbContext _context;
		private BizTalkMgmtDbEntities _bztContext;
		
		#region Items property
		private ObservableCollection<vw_FaultsByAppheader> _items;
		public ObservableCollection<vw_FaultsByAppheader> Items {
			get { return this._items; }
			set {
				if (this._items != value) {
					this._items = value;
					this.RaisePropertyChangedEvent("Items");
				}
			}
		}
		#endregion

		#region FaultCodes property
		private List<string> _faultCodes;
		public List<string> FaultCodes {
			get { return this._faultCodes; }
			set {
				if (this._faultCodes != value) {
					this._faultCodes = value;
					this.RaisePropertyChangedEvent("FaultCodes");
				}
			}
		}
		#endregion

		#region RcvLocations property
		private List<adm_ReceiveLocation> _rcvLocations;
		public List<adm_ReceiveLocation> RcvLocations {
			get { return this._rcvLocations; }
			set {
				if (this._rcvLocations != value) {
					this._rcvLocations = value;
					this.RaisePropertyChangedEvent("RcvLocations");
				}
			}
		}
		#endregion

		#region SelectedRcvLoc property
		private adm_ReceiveLocation _selectedRcvLoc;
		public adm_ReceiveLocation SelectedRcvLoc {
			get { return this._selectedRcvLoc; }
			set {
				if (this._selectedRcvLoc != value) {
					this._selectedRcvLoc = value;
					this.RaisePropertyChangedEvent("SelectedRcvLoc");
				}
			}
		}
		#endregion

		#region CurrentLimit property
		private int _currentLimit;
		public int CurrentLimit {
			get { return this._currentLimit; }
			set {
				if (this._currentLimit != value) {
					this._currentLimit = value;
					this.RaisePropertyChangedEvent("CurrentLimit");
				}
			}
		}
		#endregion

		#region CurrentRqType property
		private string _currentRqType;
		public string CurrentRqType {
			get { return this._currentRqType; }
			set {
				if (this._currentRqType != value) {
					this._currentRqType = value;
					this.RaisePropertyChangedEvent("CurrentRqType");
				}
			}
		}
		#endregion

		#region MsgContent property
		private string _msgContent;
		public string MsgContent {
			get { return this._msgContent; }
			set {
				if (this._msgContent != value) {
					this._msgContent = value;
					this.RaisePropertyChangedEvent("MsgContent");
				}
			}
		}
		#endregion

		#region MsgInfo property
		private string _msgInfo;
		public string MsgInfo {
			get { return this._msgInfo; }
			set {
				if (this._msgInfo != value) {
					this._msgInfo = value;
					this.RaisePropertyChangedEvent("MsgInfo");
				}
			}
		}
		#endregion

		#region RqTypes property
		public List<string> RqTypes { get; set; }
		#endregion

		#region Commands
		public ICommand RefreshListCmd { get; set;}
		public ICommand SetFlagTraiteCmd { get; set; }
		public ICommand ResubmitMsgCmd { get; set; }
		#endregion

		public MainViewModel() {
			this._context = new EsbExceptionDbContext();
			this._bztContext = new BizTalkMgmtDbEntities();

			this.RefreshListCmd = new RelayCommand<object>(this.RefreshList);
			this.SetFlagTraiteCmd = new RelayCommand<object>(this.SetFlagTraite);
			this.ResubmitMsgCmd = new RelayCommand<object>(this.ResubmitMsg, this.CanResubmitMsg);

			this.MsgInfo = "Cliquer sur Rechercher pour lancer la récupération des lignes.";

			this.InitializeFilterDatas();
			this.RcvLocations = this._bztContext.adm_ReceiveLocation.Where(x => x.adm_Adapter.Name == "HTTP").OrderBy(x => x.Name).ToList();
		}

		private void InitializeFilterDatas() {
			this.RqTypes = new List<string>() { TypesRequetes.All, TypesRequetes.NotTreated, TypesRequetes.Treated };
			this.CurrentRqType = TypesRequetes.NotTreated;

			this.CurrentLimit = 0;
			int.TryParse(ConfigurationManager.AppSettings.Get("SQLLimitSelect"), out this._currentLimit);

			this.FaultCodes = this._context.Faults.Select(x => x.FaultCode).Distinct().OrderBy(x => x).ToList();
			this.FaultCodes.Insert(0, FaultCodeAll);
		}

		#region private methods
		private void RefreshList(object param) {
			// on cast correctement le paramètre
			if (param != null && !(param is IEnumerable<string>)) {
				this._selectedFaultCodes = (param as IList).Cast<string>();
			}

			// requête de base
			var rqBase = from fault in this._context.vw_FaultsByAppheader
					 select fault;

			// rajout du filtre sur le type (si nécessaire)
			if (this.CurrentRqType != TypesRequetes.All) {
				rqBase = rqBase.Where(x => x.Treated == (this.CurrentRqType == TypesRequetes.Treated));
			}

			// rajout du filtre sur le fault code (si nécessaire)
			if (this._selectedFaultCodes != null && this._selectedFaultCodes.Count() > 0 && !this._selectedFaultCodes.Contains(FaultCodeAll)) {
				rqBase = rqBase.Where(x => this._selectedFaultCodes.Contains(x.FaultCode));
			}

			// rajout du tri (sur DateTime, descendant)
			rqBase = rqBase.OrderByDescending(x => x.DateTime);

			// requête permettant de connaître le nombre total de lignes sans limite
			var rqNbTotal = rqBase.Count();

			// rajout de la limite (si nécessaire)
			if (this.CurrentLimit > 0) {
				rqBase = rqBase.Take(this.CurrentLimit);
			}

			// exécution de la requête
			var watch = Stopwatch.StartNew();
			UIServices.SetBusyState();
			this.Items = new ObservableCollection<vw_FaultsByAppheader>(rqBase.ToList());
			watch.Stop();

			this.MsgInfo = string.Format("{0} ligne(s) remontée(s) (sur un total de {1}) en {2} secondes.", this.Items.Count, rqNbTotal, watch.ElapsedMilliseconds / 1000);
		}

		private void SetFlagTraite(object param) {
			var selectedFaults = (IList)param;
			var faults = selectedFaults.Cast<vw_FaultsByAppheader>();

			try {
				foreach (var fault in faults) {
					fault.Treated = true;
				}

				this._context.SaveChanges();

				this.RefreshList(this._selectedFaultCodes);
			}
			catch (Exception ex) {
				this.MsgInfo = ex.Message;
				throw;
			}
		}

		private bool CanResubmitMsg(object param) {
			//return param != null && this.SelectedRcvLoc != null;
			// TODO bouchon
			return false;
		}

		private void ResubmitMsg(object param) {
			var selectedFaults = (IList)param;
			var faults = selectedFaults.Cast<vw_FaultsByAppheader>();

			try {
				foreach (var fault in faults) {
					var msg = this._context.Messages.FirstOrDefault(x => x.FaultID == fault.FaultID);
					var msgDatas = this._context.MessageDatas.FirstOrDefault(x => x.MessageID == msg.MessageID);

					var resultCode = MessageResubmitter.ResubmitHTTP(this.SelectedRcvLoc.InboundAddressableURL, msgDatas.MessageData1, msg.ContentType);
				}

				this.RefreshList(this._selectedFaultCodes);
			}
			catch (Exception ex) {
				this.MsgInfo = ex.Message;
				throw;
			}
		}
		#endregion

		#region MVVM
		public event PropertyChangedEventHandler PropertyChanged;

		public event PropertyChangingEventHandler PropertyChanging;

		/// <summary>
		/// Whether the view model should ignore property-change events.
		/// </summary>
		public virtual bool IgnorePropertyChangeEvents { get; set; }

		/// <summary>
		/// Raises the PropertyChanged event.
		/// </summary>
		/// <param name="propertyName">The name of the changed property.</param>
		public virtual void RaisePropertyChangedEvent(string propertyName) {
			// Exit if changes ignored
			if (IgnorePropertyChangeEvents)
				return;

			// Exit if no subscribers
			if (PropertyChanged == null)
				return;

			// Raise event
			var e = new PropertyChangedEventArgs(propertyName);
			PropertyChanged(this, e);
		}

		/// <summary>
		/// Raises the PropertyChanging event.
		/// </summary>
		/// <param name="propertyName">The name of the changing property.</param>
		public virtual void RaisePropertyChangingEvent(string propertyName) {
			// Exit if changes ignored
			if (IgnorePropertyChangeEvents)
				return;

			// Exit if no subscribers
			if (PropertyChanging == null)
				return;

			// Raise event
			var e = new PropertyChangingEventArgs(propertyName);
			PropertyChanging(this, e);
		}

		#endregion
	}
}
