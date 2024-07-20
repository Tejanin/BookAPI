namespace BookAPI.Handlers
{
    public class UploadHandler
    {
        private List<string> ValidExtensions { get; set; } = new List<string> { ".pdf", ".png",".jpg" };

        private long MaxSize {  get; set; } = 1024*1024*10;

        public string Upload(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);

            if (!ValidExtensions.Contains(extension)) {
                return $"Archivo no valido ({string.Join(',', ValidExtensions)})";
            }
            
            long size = file.Length;
            if (size > MaxSize) return "Maximun file size is 10mb";

            return $"File name is {file.Name}, {file.FileName}, {file.Length}";
        }
    }
}
