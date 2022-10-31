using ToDo.DataAccess.Interfaces;
using ToDo.DataAccess.Models;

namespace ToDo.DataAccess
{
    public class ToDoService : ItoDoAction
    {
        List<ToDoItem> _toDoItems = new List<ToDoItem>()
        {
            new ToDoItem() { task="AWS",description="assignment", status="Not Completed",deadline = new DateTime(2022,10,04) ,createDate=new DateTime(2022,10,06),lastUpdateDate=new DateTime(2022,10,04)},
            new ToDoItem() { task="C#",description="assignment", status="Not Completed",deadline = new DateTime(2022,10,04) ,createDate=new DateTime(2022,10,06),lastUpdateDate=new DateTime(2022,10,04)},
            new ToDoItem() { task="Angular",description="assignment", status="Not Completed",deadline = new DateTime(2022,10,04) ,createDate=new DateTime(2022,10,06),lastUpdateDate=new DateTime(2022,10,04)},
            new ToDoItem() { task="Docker",description="assignment", status="Not Completed",deadline = new DateTime(2022,10,04) ,createDate=new DateTime(2022,10,06),lastUpdateDate=new DateTime(2022,10,04)},
        };

        public ToDoItem Search(string task)
        {
            var toDoItem = _toDoItems.Find(x => x.task == task);
            return toDoItem;
        }

        public List<ToDoItem> SearchAll()
        {
            return _toDoItems;
        }
        public List<ToDoItem> Add(ToDoItem toDoItem)
        {
            var existingToDo = _toDoItems.Find(x => x.task == toDoItem.task && x.category==toDoItem.category);
            if(existingToDo == null)
            {
                _toDoItems.Add(toDoItem);
            }
            return _toDoItems;
        }

        public List<ToDoItem> Update(ToDoItem request, string category)
        {
            var toDoItem = _toDoItems.Find(x => x.task == request.task && x.category == category);
            _toDoItems.Remove(toDoItem);
            return Add(request);
        }

        public List<ToDoItem> Delete(string task)
        {
            var toDoItem = _toDoItems.Find(x => x.task == task);
            _toDoItems.Remove(toDoItem);
            return _toDoItems;
        }

    }
}
