// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Bir X sınıfından Y sınıfı türüyor olsun. Uygulamada X yerine Y (ya da Y yerine X) rahatlıkla kullanılabiliyor olmalı.
 */

public interface IRecordable
{
    void Save();
}
public class Document
{
    public void Open() { }
    public void Close() { }




}

public class PDFDocument : Document
{

}

public class ExcelDocument : Document, IRecordable
{
    public void Save()
    {
        throw new NotImplementedException();
    }
}

public class DocumentSaver
{
    public void Save(IRecordable recordable)
    {
        recordable.Save();
    }
}