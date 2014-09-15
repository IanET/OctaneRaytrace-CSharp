﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace OctaneRaytrace_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Pulled from the Octane sources
        static int MIN_ITERATIONS = 32;
        static long REFERENCE_SCORE = 739989;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BenchmarkButton_Click(object sender, RoutedEventArgs e)
        {
            this.textBlock.Text += "Raytrace...\r\n";
            // Warmup
            Measure(null);
            // Benchmark
            Data data = new Data();
            while (data.runs < MIN_ITERATIONS) {
                Measure(data);
                this.textBlock.Text += "Runs: " + data.runs + ", Elapsed: " + data.elapsed + "\r\n";
            }
            long usec = (data.elapsed * 1000) / data.runs;
            long score = (REFERENCE_SCORE / usec) * 100;
            this.textBlock.Text += "Score: " + score + "\r\n";
            this.textBlock.Text += "Done\r\n\r\n";            
        }

        private void RenderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public class Data
        {
            public long runs;
            public long elapsed;
        }

        public void Measure(Data data)
        {
            // Run for a second
            Stopwatch sw = new Stopwatch();
            int i = 0;

            sw.Start();
            while (sw.ElapsedMilliseconds < 1000)
            {
                RayTracer.renderScene(null);
                i++;
            }
            sw.Stop();

            if (data != null)
            {
                data.runs += i;
                data.elapsed += sw.ElapsedMilliseconds;
            }
        }

       
    }
}
