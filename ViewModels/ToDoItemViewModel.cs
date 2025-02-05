﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zada2.Models;

namespace zada2.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {

        [ObservableProperty]
        private bool _isChecked;

        [ObservableProperty]
        private string? _content;
        public ToDoItemViewModel()
        {
            // empty
        }
        public ToDoItemViewModel(ToDoItem item)
        {
            IsChecked = item.IsChecked;
            Content = item.Content;
        }
        public ToDoItem GetToDoItem()
        {
            return new ToDoItem()
            {
                IsChecked = this.IsChecked,
                Content = this.Content
            };
        }
    }

}
