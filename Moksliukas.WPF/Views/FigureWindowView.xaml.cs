using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Moksliukas.Core.Models;
using Moksliukas.Core.ViewModels;
using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace Moksliukas.WPF.Views
{
    public partial class FigureWindowView : Window
    {
        FigureViewModel FigureVM;
        FigureModel figure;

        // Controls 
        List<TextBox> figureArgumentTextBoxes = new List<TextBox>();
        TextBox resultsTextBox = new TextBox();

        public FigureWindowView(int selectedFigureIndex)
        {
            InitializeComponent();
            this.FigureVM = new FigureViewModel(selectedFigureIndex);
            this.DataContext = FigureVM;
            this.figure = FigureVM.Figure;
            this.createArgumentTextBoxes();
            this.Show();
        }

        public void createArgumentTextBoxes()
        {
            List<FigureArgumentModel> figureArguments = this.figure.GetFigureArguments();
            for (int i = 0; i < figureArguments.Count; i++)
            {
                FigureArgumentModel figureArgument = figureArguments[i];
                TextBlock argumentLabel = new TextBlock();
                argumentLabel.Text = figureArgument.FigureArgumentName + " - " + figureArgument.FigureArgumentDescription;
                
                TextBox argumentTextBox = new TextBox();
                argumentTextBox.Name = "argumentTextBox_" + i;

                this.stackpanel.Children.Add(argumentLabel);
                this.stackpanel.Children.Add(argumentTextBox);
                this.figureArgumentTextBoxes.Add(argumentTextBox);
            }

            TextBlock resultsLabel = new TextBlock();
            resultsLabel.Text = "Result";
            this.stackpanel.Children.Add(resultsLabel);
            this.stackpanel.Children.Add(this.resultsTextBox);

            Button calculateButton = new Button();
            calculateButton.Content = "Calculate";
            calculateButton.Name = "calculateButton";
            calculateButton.Click += calculateButton_Click;
            this.stackpanel.Children.Add(calculateButton);

        }


        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            Expression figureExpression = new Expression(figure.FigureExpression);
            for (int i = 0; i < figureArgumentTextBoxes.Count; i++)
            {
                TextBox figureArgumentTextBox = figureArgumentTextBoxes[i];
                FigureArgumentModel figureArgument = this.figure.GetFigureArguments()[i];
                double value = Double.Parse(figureArgumentTextBox.Text);
                figureExpression.defineArgument​(figureArgument.FigureArgumentName, value);
                resultsTextBox.Text = figureExpression.getExpressionString() + " = " + figureExpression.calculate();
            }

        }
    }
}
