namespace SnippetMaker
{
    public static class InputHandler
    {
        /// <summary>
        /// Determines whether a key press event contains a letter, control character, or white space character.
        /// </summary>
        public static void IsLetter(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        /// <summary>
        /// Determines whether a key press event contains a letter or control character, but not a space character.
        /// </summary>
        public static void IsLetterNoSpace(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Determines whether a key press event contains a letter, control character, or punctuation character, but not a space character.
        /// </summary>
        public static void IsLetterOrPunctuationNoSpace(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        /// <summary>
        /// Determines whether a key press event contains a letter, control character, or dot character, but not a space character.
        /// </summary>
        public static void IsLetterOrDotNoSpace(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        /// <summary>
        /// Determines whether a key press event contains a number or control character.
        /// </summary>
        public static void IsNumber(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}