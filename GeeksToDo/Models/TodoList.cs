using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksToDo.Models
{
    public class TodoList
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public List<TodoItem> Items { get; set; }



        public TodoList(string title, List<TodoItem> items)
        {
            Id = Guid.NewGuid();
            Title = title;
            Items = items;
        }

        public TodoList(string title)
        {
            Title = title;
            Id = Guid.NewGuid();

            Items = new List<TodoItem>();
        }

        public int getCompletedCount()
        {
            return this.Items.Count(x => x.IsDone == true);
        }

        public int getRemainingCount()
        {

            return this.Items.Count(x => x.IsDone == false);
        }

        
    }
}
