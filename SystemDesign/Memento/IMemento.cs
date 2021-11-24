using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemDesign.Memento
{
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }

    public class MoodStateMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public MoodStateMemento(string state)
        {
            this._state = state;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"Created this memento at date {_date.ToString()}";
        }

        public string GetState()
        {
            return _state;
        }
    }

    public class Person
    {
        private string _moodState;

        public Person(string state)
        {
            this._moodState = state;
        }

        public void ChangeMood(string mood)
        {
            this._moodState = mood;
        }

        public IMemento Save()
        {
            return new MoodStateMemento(_moodState);
        }

        public void RestoreMood(IMemento memento)
        {
            this._moodState = memento.GetState();
        }
    }

    public class PersonMoodHandler
    {
        private List<IMemento> mementos = new List<IMemento>();
        private Person person;

        public PersonMoodHandler(Person person)
        {
            this.person = person;
        }

        public void TakeSnapshot()
        {
            this.mementos.Add(person.Save());
        }

        public void RestoreMood()
        {
            if (this.mementos.Count == 0) return;

            var last = this.mementos.Last();
            this.mementos.Remove(last);

            this.person.RestoreMood(last);

        }

        public void ShowHistory()
        {
            foreach (var memento in mementos)
                Console.WriteLine(memento.GetName() + " " + memento.GetState());
            Console.WriteLine();
        }
    }
}
