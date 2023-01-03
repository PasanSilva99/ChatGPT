using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChatGPT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebViewcx.Reload();
        }

        private void Button_PointerEntered(object sender, PointerRoutedEventArgs ee)
        {
            // Get the button
            Button button = sender as Button;

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = button.ActualWidth;
            widthAnimation.To = 200;
            widthAnimation.Duration = TimeSpan.FromSeconds(1);

            // Set the button's width to the target value when the animation completes
            widthAnimation.Completed += (s, e) => button.Width = 200;

            // Create a Storyboard to contain the animation
            Storyboard storyboard = new Storyboard();

            // Add the animation to the Storyboard
            storyboard.Children.Add(widthAnimation);

            // Set the target property of the animation to the Button's Width property
            Storyboard.SetTargetProperty(widthAnimation, "Width");

            // Set the Storyboard's target to the Button
            Storyboard.SetTarget(storyboard, button);

            // Start the Storyboard
            storyboard.Begin();

        }

        private void Button_PointerExited(object sender, PointerRoutedEventArgs ee)
        {
            // Get the button
            Button button = sender as Button;

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = button.ActualWidth;
            widthAnimation.To = 40;
            widthAnimation.Duration = TimeSpan.FromSeconds(1);

            // Set the button's width to the target value when the animation completes
            widthAnimation.Completed += (s, e) => button.Width = 40;

            // Create a Storyboard to contain the animation
            Storyboard storyboard = new Storyboard();

            // Add the animation to the Storyboard
            storyboard.Children.Add(widthAnimation);

            // Set the target property of the animation to the Button's Width property
            Storyboard.SetTargetProperty(widthAnimation, "Width");

            // Set the Storyboard's target to the Button
            Storyboard.SetTarget(storyboard, button);

            // Start the Storyboard
            storyboard.Begin();
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            
        }
    }
}
