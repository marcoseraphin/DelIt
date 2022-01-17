using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace delt.ContentViews
{
    public partial class ShowItemCV : ContentView
    {
        public static readonly BindableProperty ShowIDProperty = BindableProperty.Create(
          nameof(ShowID),
          typeof(string),
          typeof(ShowItemCV));

        public static readonly BindableProperty ShowClassificationProperty = BindableProperty.Create(
          nameof(ShowClassification),
          typeof(string),
          typeof(ShowItemCV));

        public static readonly BindableProperty ShowLogoUrlProperty = BindableProperty.Create(
           nameof(ShowLogoUrl),
           typeof(ImageSource),
           typeof(ShowItemCV));

        public static readonly BindableProperty IconRightProperty = BindableProperty.Create(
          nameof(IconRight),
          typeof(string),
          typeof(ShowItemCV));

        public static readonly BindableProperty CountryImageProperty = BindableProperty.Create(
          nameof(CountryImage),
          typeof(string),
          typeof(ShowItemCV));

        public static readonly BindableProperty ShowTitleProperty = BindableProperty.Create(
            nameof(ShowTitle),
            typeof(string),
            typeof(ShowItemCV),
            String.Empty);

        public static readonly BindableProperty SubTextProperty = BindableProperty.Create(
           nameof(SubText),
           typeof(string),
           typeof(ShowItemCV),
           String.Empty);

        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(ICommand),
            typeof(ShowItemCV));

        public static readonly BindableProperty ShowCountryProperty = BindableProperty.Create(
            nameof(ShowCountry),
            typeof(string),
            typeof(ShowItemCV),
            propertyChanged: ShowCountryPropertyChanged);


        public String ShowID
        {
            get => (String)GetValue(ShowIDProperty);
            set => SetValue(ShowIDProperty, value);
        }

        public String ShowClassification
        {
            get => (String)GetValue(ShowClassificationProperty);
            set => SetValue(ShowClassificationProperty, value);
        }

        public ImageSource ShowLogoUrl
        {
            get => (ImageSource)GetValue(ShowLogoUrlProperty);
            set => SetValue(ShowLogoUrlProperty, value);
        }

        public String IconRight
        {
            get => (String)GetValue(IconRightProperty);
            set => SetValue(IconRightProperty, value);
        }

        public String CountryImage
        {
            get => (String)GetValue(CountryImageProperty);
            set => SetValue(CountryImageProperty, value);
        }

        public string ShowTitle
        {
            get => (string)GetValue(ShowTitleProperty);
            set => SetValue(ShowTitleProperty, value);
        }

        public string SubText
        {
            get => (string)GetValue(SubTextProperty);
            set => SetValue(SubTextProperty, value);
        }

        public string ShowCountry
        {
            get => (string)GetValue(ShowCountryProperty);
            set => SetValue(ShowCountryProperty, value);
        }

        private static void ShowCountryPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bindable is ShowItemCV showItem) && (newValue is String countryCode))
            {
                showItem.UpdateCountryImage(countryCode);
            }

        }

        private void UpdateCountryImage(string countryCode)
        {
            switch (countryCode)
            {
                case "de-DE":
                    InnerCountrySvgImage.Source = "germany.svg";
                    break;

                case "en-EN":
                    InnerCountrySvgImage.Source = "unitedkingdom.svg";
                    break;


                default:
                    break;
            }
        }

        /// <summary>
        /// Command
        /// </summary>
        public ICommand Command
        {
            get => (ICommand)this.GetValue(CommandProperty);
            set => this.SetValue(CommandProperty, value);
        }

        /// <summary>
        /// ctor
        /// </summary>
        public ShowItemCV()
        {
            InitializeComponent();
            this.InnerFrame.BindingContext = this;
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            this.Command?.Execute(this);
        }
    }
}
