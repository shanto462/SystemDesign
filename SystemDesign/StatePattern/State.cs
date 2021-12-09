using System;
using System.Collections.Generic;
using System.Text;

namespace SystemDesign.StatePattern
{
    public class Publication
    {
        private State _state;

        public Publication(State state)
        {
            this._state = state;
        }

        public void TransitionTo(State state)
        {
            this._state = state;
            Console.WriteLine("Current state -> " + state.GetType().Name);
        }
    }

    public abstract class State
    {
        public Publication publication;
        public abstract void Do();

        public State(Publication publication)
        {
            this.publication = publication;
        }
    }

    public class DraftState : State
    {
        public DraftState(Publication publication) : base(publication)
        {

        }
        public override void Do()
        {
            Console.WriteLine("making draft");
            publication.TransitionTo(new DrafttState(publication));
        }
    }

    public class DrafttState : State
    {
        public DrafttState(Publication publication) : base(publication)
        {

        }
        public override void Do()
        {
            Console.WriteLine("making draftt");
            publication.TransitionTo(new DraftState(publication));
        }
    }
}
