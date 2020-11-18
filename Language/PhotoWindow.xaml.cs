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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace Language
{
    /// <summary>
    /// Логика взаимодействия для PhotoWindow.xaml
    /// </summary>
    public partial class PhotoWindow : Window
    {
        public PhotoWindow()
        {
            InitializeComponent();
        }

        private void UploadPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                var bruh = openFileDialog.FileName;
                var converter = new ImageSourceConverter();
                var loh = (ImageSource)converter.ConvertFromString(bruh);
                var bitmapSource = loh as BitmapSource;
                Anime.Source = loh;

                using (var memory = new MemoryStream())
                {
                    //Stream stream = bitmapSource.GetStream();
                    //stream.CopyTo(memory);
                    //imageArray = memory.ToArray();
                }
                

            }
        }
    }
}
