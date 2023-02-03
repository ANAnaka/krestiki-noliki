using System;
using System.Collections.Generic;
using System.Data;
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

namespace Папа_купи_пёика
{
    
    public partial class MainWindow : Window
    {
        Logics logic = new Logics();
        public MainWindow()
        {
            InitializeComponent();
            block();
        }
        private void block()
        {
            _1.IsHitTestVisible = false;
            _2.IsHitTestVisible = false;
            _3.IsHitTestVisible = false;
            _4.IsHitTestVisible = false;
            _5.IsHitTestVisible = false;
            _6.IsHitTestVisible = false;
            _7.IsHitTestVisible = false;
            _8.IsHitTestVisible = false;
            _9.IsHitTestVisible = false;
        }

        private void  make_move(Button box)
        {
            int x, y;
            string tag = box.Tag.ToString();
            x = int.Parse (tag.Substring(0,1));
            y = int.Parse(tag.Substring(1, 1));
            int side = logic.side;
            if (logic.Place(x, y))
            {
                if (side == 1)
                {
                    krest((Button)box);
                    
                }
                else
                {
                    nolik((Button)box);
                    
                }
                if(logic.finish != "play")
                {
                    konec();
                }
            }
        }
        private void konec()
        {
            switch (logic.finish) 
            {
                case "Winx": Nadpis.Text = "Крестики победили\n Конец игры"; return;
                case "Wino": Nadpis.Text = "Нолики победили\n Конец игры"; return;
                case "draw": Nadpis.Text = "Ничья\n Конец игры"; return;
                default: return;
            }
        }
        private void krest(Button box)
        {
            var a = new Uri(System.IO.Path.GetFullPath(@"..\..\Images\krest.jpg"), UriKind.Relative);
            ImageBrush krest = new ImageBrush(new BitmapImage(a));
            box.Background = krest;
        }
        private void nolik(Button box)
        {
            var a = new Uri(System.IO.Path.GetFullPath(@"..\..\Images\Nolik.jpg"), UriKind.Relative);
            ImageBrush nolik = new ImageBrush(new BitmapImage(a));
            box.Background = nolik;
        }
        private void _1_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button) sender);
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            make_move((Button)sender);
        }

        private void Основа_Click(object sender, RoutedEventArgs e)
        {
            Nadpis.Text = null;
            logic.Init();
            
            _1.Background = null;
            _2.Background = null;
            _3.Background = null;
            _4.Background = null;
            _5.Background = null;
            _6.Background = null;
            _7.Background = null;
            _8.Background = null;
            _9.Background = null;

            _1.IsHitTestVisible = true;
            _2.IsHitTestVisible = true;
            _3.IsHitTestVisible = true;
            _4.IsHitTestVisible = true;
            _5.IsHitTestVisible = true;
            _6.IsHitTestVisible = true;
            _7.IsHitTestVisible = true;
            _8.IsHitTestVisible = true;
            _9.IsHitTestVisible = true;
        }

        private void конец_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
