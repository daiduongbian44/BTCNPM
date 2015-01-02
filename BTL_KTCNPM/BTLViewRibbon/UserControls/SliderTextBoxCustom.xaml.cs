using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BTLViewRibbon.UserControls
{
    /// <summary>
    /// Interaction logic for SliderTextBoxCustom.xaml
    /// </summary>
    public partial class SliderTextBoxCustom : UserControl
    {
        private bool changeValueTextSlider = true;

        /// <summary>
        /// Return value of slider
        /// </summary>
        public double ValuesSlider
        {
            get
            {
                return this.slider.Value;
            }
        }


        public SliderTextBoxCustom()
        {
            InitializeComponent();

            this.slider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(slider_ValueChanged);
            this.textBox.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
            this.slider.Value = 0;
            this.textBox.Text = "0";
        }

        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
            {
                try
                {
                    var value = int.Parse(this.textBox.Text + e.Text);
                    if (value >= slider.Minimum && value <= slider.Maximum)
                    {
                        e.Handled = false;
                        changeValueTextSlider = false;
                        this.slider.Value = value;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                catch (Exception)
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }

            base.OnPreviewTextInput(e);
        }

        void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (changeValueTextSlider)
            {
                this.textBox.Text = this.slider.Value.ToString();
            }
            changeValueTextSlider = true;
        }
    }
}
