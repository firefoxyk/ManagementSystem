using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain.Poll
{
    public class Poll//переделай на агрегат
    {
        private Poll(string pollHeadline, string pollBody, string[] pollAnswerOptions)
        {
            IdPoll = Guid.NewGuid();
            PollHeadline = pollHeadline;
            PollBody = pollBody;
            PollAnswerOptions = pollAnswerOptions;

            PollVotes = new int[pollAnswerOptions.Length, 0];// Инициализировать массив голосов нулями
        }
        public Guid IdPoll { get; set; }
        public string PollHeadline { get; set; }
        public string PollBody { get; set; }
        public string[] PollAnswerOptions { get; set; }
        public int[,] PollVotes { get; set; }

        public static Poll Create(string pollHeadline, string pollBody, string[] pollAnswerOptions)
        {
            if (string.IsNullOrEmpty(pollHeadline) || string.IsNullOrEmpty(pollBody) || pollAnswerOptions == null || pollAnswerOptions.Length == 0)
            {
                return null;
            }
            return new Poll(pollHeadline, pollBody, pollAnswerOptions);
        }
    }
}
