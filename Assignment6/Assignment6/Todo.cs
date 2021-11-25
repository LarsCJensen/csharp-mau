﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Todo
    {
        // Store data and handle operation for a todo
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private DateTime todoDate;
        public DateTime TodoDate
        {
            get
            {
                return todoDate;
            }
            set
            {
                todoDate = value;
            }
        }
        private string priority;
        public string Priority
        {
            get
            {
                return priority;
            }            
            set
            {
                priority = value;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Todo() { }

        public Todo(Todo newTodo)
        {
            title = newTodo.Title;
            todoDate = newTodo.TodoDate;
            priority = newTodo.Priority;
        }

        
        /// <summary>
        /// Checking if title and date is valid
        /// </summary>
        /// <returns></returns>
        public bool ValidateData()
        {
            if (string.IsNullOrEmpty(title) ||
                (todoDate <= DateTime.Now))
            {
                return false;
            }
            return true;
        }
    }
}