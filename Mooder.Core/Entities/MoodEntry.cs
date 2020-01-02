using System;

namespace Mooder.Core.Entities
{
    public sealed class MoodEntry
    {
        public DateTime EntryDateTime { get; private set; }
        public MoodType MoodType { get; private set; }
    }
}
