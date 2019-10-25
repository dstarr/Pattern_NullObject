using System;
using NullObject.Entities;

namespace NullObject.View
{
    public class LearnerView
    {
        private readonly Learner _learner;

        public LearnerView(Learner learner)
        {
            if (learner == null) throw new ArgumentNullException(nameof(learner));
            
            _learner = learner;
        }

        public void RenderView()
        {
            Console.WriteLine("User Name: " + _learner.UserName);
            Console.WriteLine("Courses Completed: " + _learner.CoursesCompleted);
        }
    }
}