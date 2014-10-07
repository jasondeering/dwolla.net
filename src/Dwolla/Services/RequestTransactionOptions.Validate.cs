using Newtonsoft.Json;

namespace Dwolla.Services
{
    public partial class RequestTransactionOptions
    {
        private const int MAX_NOTE_LENGTH = 250;

        public static bool IsValidNote(string note)
        {
            return note.Length <= MAX_NOTE_LENGTH;
        }

        public bool NotesAreValid()
        {
            return IsValidNote(this.Notes);
        }
    }
}
