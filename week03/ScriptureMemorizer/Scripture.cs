public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public string GetDisplayText()
        {
            string wordsDisplay = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return $"{_reference.GetDisplayText()} - {wordsDisplay}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }
    }