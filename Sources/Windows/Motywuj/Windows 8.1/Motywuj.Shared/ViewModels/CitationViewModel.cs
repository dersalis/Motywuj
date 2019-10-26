using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using Motywuj.Models;

namespace Motywuj.ViewModels
{
    public class CitationViewModel : INotifyPropertyChanged
    {
        // Wylosowany cytat
        private Citation _selectedCitation;
        public Citation SelectedCitation 
        {
            get { return _selectedCitation; }
            set
            {
                if (_selectedCitation != value)
                {
                    _selectedCitation = value;
                    NotifyPropertyChanged("SelectedCitation");
                }
            }
        }


        /*
         * Konstruktor
         */
        public CitationViewModel()
        {
            SelectedCitation = new Citation() { Content = "To jest treść wylosowanego lub wybranego przez Ciebie cytatu", Author = "Damian Ruta", Id = Guid.NewGuid().ToString()};
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
