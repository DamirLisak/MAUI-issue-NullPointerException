using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace gip.vbm.mobile
{
    public class BarcodeScannerEventArgs : EventArgs
    {
        public BarcodeScannerEventArgs(object value)
        {
            this.Value = value;
        }
        public object Value { get; private set; }
    }


    /// <summary>
    /// Component for barcode scan. Important: Call OnAppearing() and OnDisappearing() from host (parent) page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarcodeScannerView : ContentView
    {
        #region events
        //public event EventHandler<BarcodeScannerEventArgs> OnBarcodeCommandInvoked;
        public event EventHandler<BarcodeScannerEventArgs> OnBarcodeEntityTapped;
        //public event EventHandler<BarcodeScannerEventArgs> OnNewBarcodeScanned;
        public event EventHandler OnCleanUpForm;
        public event EventHandler OnTextChanged;
        #endregion

        #region ctor's
        public BarcodeScannerView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public static BindableProperty ShowDecodedEntitiesProperty = BindableProperty.Create(
     propertyName: nameof(ShowDecodedEntities),
     returnType: typeof(bool),
     declaringType: typeof(BarcodeScannerView),
     defaultValue: true,
     defaultBindingMode: BindingMode.TwoWay);

        /// <summary>
        /// With BarcodeServiceMethod you control which "Barcode"-Method is called on Serverside
        /// </summary>
        public bool ShowDecodedEntities
        {
            get
            {
                return (bool)base.GetValue(ShowDecodedEntitiesProperty);
            }
            set
            {
                base.SetValue(ShowDecodedEntitiesProperty, value);
            }
        }

        public BarcodeScanModelBase ViewModel
        {
            get
            {
                return BindingContext as BarcodeScanModelBase;
            }
            set
            {
                BindingContext = value;
            }
        }
        #endregion

        #region UI-Event-Handling
        private static void HandleValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }

        private void BarcodeSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OnTextChanged != null)
                OnTextChanged(this, new EventArgs());
        }

        private void BarcodeSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
        }

        private void BarcodeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        }

        private void BarcodeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            OnBarcodeEntityTapped?.Invoke(this, new BarcodeScannerEventArgs(e.Item));
        }

        private void btnClearList_Clicked(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Clean up forms and prepare for next usage
        /// </summary>
        public void Clear()
        {
            ViewModel?.Clear();
            if (OnCleanUpForm != null)
                OnCleanUpForm(this, new EventArgs() { });
        }
        #endregion
    }
}