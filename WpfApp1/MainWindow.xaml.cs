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
using System.Windows.Media; // Brushes Colors
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
        }

        private void handleCreateLine(object sender, RoutedEventArgs e)
        {
            Line line = new Line();
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

            double top = Convert.ToDouble(rectangle_top.Text);
            double left = Convert.ToDouble(rectangle_left.Text);

            Canvas.SetTop(rect, top);
            Canvas.SetLeft(rect, left);

            canvas_container.Children.Add(rect);
        }

        private void handleCreateSquare(object sender, RoutedEventArgs e)
        {
            Rectangle sqr = new Rectangle();
            sqr.Stroke = new SolidColorBrush(Colors.MediumVioletRed);
            sqr.Fill = new SolidColorBrush(Colors.MediumPurple);

            sqr.Width = Convert.ToDouble(square_side.Text);
            sqr.Height = Convert.ToDouble(square_side.Text);
            Canvas.SetTop(sqr, Convert.ToDouble(square_top.Text));
            Canvas.SetLeft(sqr, Convert.ToDouble(square_left.Text));

            canvas_container.Children.Add(sqr);
        }

        private void handleCreateEllipse(object sender, RoutedEventArgs e)
        {
            // Add an Ellipse Element
            Ellipse myEllipse = new Ellipse();
            myEllipse.Stroke = Brushes.MediumPurple;
            myEllipse.Fill = Brushes.OrangeRed;

            myEllipse.Width = Convert.ToDouble(ellipse_width.Text);
            myEllipse.Height = Convert.ToDouble(ellipse_height.Text);

            Canvas.SetTop(myEllipse, Convert.ToDouble(ellipse_top.Text));
            Canvas.SetLeft(myEllipse, Convert.ToDouble(ellipse_left.Text));

            canvas_container.Children.Add(myEllipse);
        }

        private void handleCreateTriangle(object sender, RoutedEventArgs e)
        {
            // Create a Polygon
            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = Brushes.Black;
            myPolygon.Fill = Brushes.LightSeaGreen;
            myPolygon.StrokeThickness = 2;

            // Create a collection of points for the Polygon
            PointCollection myPointCollection = new PointCollection();

            double x1 = Convert.ToDouble(triangle_x1.Text);
            double y1 = Convert.ToDouble(triangle_y1.Text);
            double x2 = Convert.ToDouble(triangle_x2.Text);
            double y2 = Convert.ToDouble(triangle_y2.Text);
            double x3 = Convert.ToDouble(triangle_x3.Text);
            double y3 = Convert.ToDouble(triangle_y3.Text);

            myPointCollection.Add(new Point(x1, y1));
            myPointCollection.Add(new Point(x2, y2));
            myPointCollection.Add(new Point(x3, y3));

            // Set Polygon.Points to the PointCollection
            myPolygon.Points = myPointCollection;
            canvas_container.Children.Add(myPolygon);
        }
    }
}
