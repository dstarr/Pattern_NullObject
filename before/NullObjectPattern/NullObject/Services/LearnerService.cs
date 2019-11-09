using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using NullObject.Entities;

namespace NullObject.Services
{
    public class LearnerService
    {
        readonly LearnerRepo _repo = new LearnerRepo();
        
        public ILearner GetLearner(int id)
        {
            var learner = _repo.GetLearner(id);
            
            if (learner == null) throw new NullReferenceException();

            return learner;
        }

        class LearnerRepo
        {
            readonly IList<Learner> _learners = new List<Learner>();

            internal LearnerRepo()
            {
                _learners.Add(new Learner(1, "David", 83));
                _learners.Add(new Learner(2, "Julie", 72));
                _learners.Add(new Learner(3, "Scott", 92));
            }

            internal ILearner GetLearner(int id)
            {
                bool learnerExists = _learners.Any(l => l.Id == id);

                if (learnerExists)
                    return _learners.FirstOrDefault(l => l.Id == id);

                return null;
            }
        }
        
    }
}