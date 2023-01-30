using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void handleClearCanva(object sender, RoutedEventArgs e)
        {
            canvas_container.Children.Clear();
            canvas_container.Children.Add(canvas_clr_btn);
        }

        private void handleCreateLine(object sender, RoutedEventArgs e)
        {
            Line line = new Line();
            Thickness thickness = new Thickness(101, -11, 362, 250);
            line.Margin = thickness;
            line.Visibility = Visibility.Visible;
            line.StrokeThickness = 3;
            line.Stroke = Brushes.Black;
            line.X1 = Convert.ToDouble(line_x1.Text);
            line.X2 = Convert.ToDouble(line_x2.Text);
            line.Y1 = Convert.ToDouble(line_y1.Text);
            line.Y2 = Convert.ToDouble(line_y2.Text);

            canvas_container.Children.Add(line);
        }

        private void handleCreateRectangle(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.MediumPurple);
            rect.Fill = new SolidColorBrush(Colors.ForestGreen);

            rect.Width = Convert.ToDouble(rectangle_width.Text);
            rect.Height = Convert.ToDouble(rectangle_height.Text);
            Canvas.SetTop(rect, Convert.ToDouble(rectangle_top.Text));
            Canvas.SetRight(rect, Convert.ToDouble(rectangle_right.Text));
            Canvas.SetBottom(rect, Convert.ToDouble(rectangle_bottom.Text));
            Canvas.SetLeft(rect, Convert.ToDouble(rectangle_left.Text));

            canvas_container.Children.Add(rect);
        }

        private void handleCreateSquare(object sender, RoutedEventArgs e)
        {
            Rectangle sqr = new Rectangle();
            sqr.Stroke = new SolidColorBrush(Colors.MediumPurple);
            sqr.Fill = new SolidColorBrush(Colors.ForestGreen);

            sqr.Width = Convert.ToDouble(square_side.Text);
            sqr.Height = Convert.ToDouble(square_side.Text);
            Canvas.SetTop(sqr, Convert.ToDouble(square_top.Text));
            Canvas.SetRight(sqr, Convert.ToDouble(square_right.Text));
            Canvas.SetBottom(sqr, Convert.ToDouble(square_bottom.Text));
            Canvas.SetLeft(sqr, Convert.ToDouble(square_left.Text));

            canvas_container.Children.Add(sqr);
        }

        private void handleCreateEllipse(object sender, RoutedEventArgs e)
        {
            // Add an Ellipse Element
            Ellipse myEllipse = new Ellipse();
            myEllipse.Stroke = Brushes.MediumPurple;
            myEllipse.Fill = Brushes.ForestGreen;

            myEllipse.Width = Convert.ToDouble(ellipse_width.Text);
            myEllipse.Height = Convert.ToDouble(ellipse_height.Text);

            Canvas.SetTop(myEllipse, Convert.ToDouble(ellipse_top.Text));
            Canvas.SetRight(myEllipse, Convert.ToDouble(ellipse_right.Text));
            Canvas.SetBottom(myEllipse, Convert.ToDouble(ellipse_bottom.Text));
            Canvas.SetLeft(myEllipse, Convert.ToDouble(ellipse_left.Text));

            canvas_container.Children.Add(myEllipse);
        }
    }
}
