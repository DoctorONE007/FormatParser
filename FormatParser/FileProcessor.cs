using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatParser
{
    public class FileProcessor
    {
       

        public void ProcessFile(string fileName)
        {
            try
            {
                string ext = Path.GetExtension(fileName);
                Console.WriteLine(Path.GetFileName(fileName));
                switch (ext.ToLower())
                {
                    case ".bin":
                        Console.WriteLine("Двоичный файл, используемый с различными программами. Файл изображения компакт-диска (CD). Таблицы переводов для кодовых страниц, отличных от стандарта 437.");
                        break;
                    case ".cpp":
                        Console.WriteLine("Исходный код языка C++.");
                        break;
                    case ".csw":
                        Console.WriteLine("Файл значений, разделенных запятым, используемый с базами данных и таблицами");
                        break;
                    case ".css":
                        Console.WriteLine("Файл таблицы стилей CSS.");
                        break;
                    case ".dll":
                        Console.WriteLine("Файл Dynamic Link Library (библиотека динамической связки) или файл библиотеки значков.");
                        break;
                    case ".doc":
                        Console.WriteLine("Файл текстового редактора Microsoft Word.");
                        break;
                    case ".docx":
                        Console.WriteLine("Файл редактора Microsoft Word представленный с выходом Microsoft Word 2007.");
                        break;
                    case ".dos":
                        Console.WriteLine("Текстовый файл и информация о спецификации DOS.");
                        break;
                    case ".exe":
                        Console.WriteLine("Исполняемый файл, или файл библиотеки значков.");
                        break;
                    case ".html":
                        Console.WriteLine("Файлы веб-страниц, содержащие HTML и другую информацию.");
                        break;
                    case ".iso":
                        Console.WriteLine("	Образ диска – сжатый файл, используемый для точного дублирования компакт-диска. Файл .ISO могут извлечь или открыть такие программы, как Daemon Toos, Win Image и другие.");
                        break;
                    case ".jar":
                        Console.WriteLine("Сжатый файл, используемый с ARJ Software, и сжатый файл, содержащий пакеты и классы Java.");
                        break;
                    case ".jpg":
                        Console.WriteLine("Популярный файл изображений, обычно используемый в интернете.");
                        break;
                    case ".jpeg":
                        Console.WriteLine("Популярный файл изображений, обычно используемый в интернете.");
                        break;
                    case ".json":
                        Console.WriteLine("Текстовый формат обмена данными, часто применяется в AJAX запросах между браузером и сервером.");
                        break;
                    case ".mp3":
                        Console.WriteLine("MPEG аудио поток, слой III");
                        break;
                    case ".rar":
                        Console.WriteLine("Сжатый файл WinRAR");
                        break;
                    case ".txt":
                        Console.WriteLine("Обычный текстовый файл, который можно прочитать любым текстовым редактором.");
                        break;
                    case ".zip":
                        Console.WriteLine("Сжатый файл, один из популярных в интернете форматов.");
                        break;
                    default:
                        Console.WriteLine("К сожалению данное расширение либо отсутсвует, либо пока не поддерживается");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

    }

}
