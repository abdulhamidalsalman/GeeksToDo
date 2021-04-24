using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksToDo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public DateTime? DueDate { get; set; }

        public string Note { get; set; }

        public TodoItem(string title, bool isDone, DateTime dueDate, string note)
        {
            Id = Guid.NewGuid(); ;
            Title = title;
            IsDone = isDone;
            DueDate = dueDate;
            Note = note;
        }

        public TodoItem( string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            IsDone = false;
        }
    }
}
