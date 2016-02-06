namespace SimpleFileEditor
{
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Filed editor class.
    /// </summary>
    public class FileEditor
    {
        /// <summary>
        /// Contains the path to the file.
        /// </summary>
        private readonly string filePath;

        /// <summary>
        /// Hold the content of the current file.
        /// </summary>
        private StringBuilder currentFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileEditor"/> class.
        /// </summary>
        /// <param name="filePath">Path to the file.</param>
        public FileEditor(string filePath)
        {
            this.filePath = filePath;
            this.currentFile = new StringBuilder();
        }

        /// <summary>
        /// Lists the content of the file.
        /// </summary>
        /// <returns>The contents of the file.</returns>
        public string List()
        {
            this.currentFile = new StringBuilder(string.Join("\n", File.ReadAllLines(this.filePath)));
            return this.currentFile.ToString();
        }

        /// <summary>
        /// Deletes all contents from the file.
        /// </summary>
        public void Clear()
        {
            this.currentFile = new StringBuilder();
            File.WriteAllText(this.filePath, this.currentFile.ToString());
        }

        /// <summary>
        /// Appends new line to the file.
        /// </summary>
        /// <returns>The file for chaining.</returns>
        public FileEditor AppendLine()
        {
            this.currentFile.AppendLine("\n");
            File.WriteAllText(this.filePath, this.currentFile.ToString());
            return this;
        }

        /// <summary>
        /// Appends text to the file.
        /// </summary>
        /// <param name="stringToAppend">String to append to the file.</param>
        /// <returns>The file for chaining.</returns>
        public FileEditor Append(string stringToAppend)
        {
            this.currentFile.Append(stringToAppend);
            File.WriteAllText(this.filePath, this.currentFile.ToString());
            return this;
        }

        /// <summary>
        /// Counts the lines of the file.
        /// </summary>
        /// <returns>Number of the lines in the file.</returns>
        public int LinesCount()
        {
            return File.ReadLines(this.filePath).Count();
        }
    }
}
