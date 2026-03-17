using System.Xml.Serialization;

namespace WinFormsApp69;

public class Controller
{
    #region Felder
    private Form1 _form;
    #endregion

    #region Accessoren
    private Form1 Form { get => _form; set => _form = value; }
    #endregion

    #region Konstruktoren
    public Controller()
    {
        // Die aktuelle Instanz vom Kontroller wird an das Form übergeben, damit das Form auf die Funktionen des Controllers zugreifen kann.
        _form = new Form1(this);
    }
    #endregion

    #region Worker
    public void Run()
    {
        Form.ShowDialog();
    }

    public void Speichern(string eingabe)
    {
        // In typeof(string) wird der Typ der Daten angegeben, die serialisiert werden sollen.
        // In diesem Fall ist es ein einfacher String können aber auch mehrere Datentypen sein.
        XmlSerializer serializer = new XmlSerializer(typeof(string), new Type[] { typeof(int), typeof(double) });

        // Unser Writer der die Datei erstellt und die Daten in die Datei schreibt
        // "using" sorgt dafür, dass der StreamWriter automatisch geschlossen wird, nachdem er verwendet wurde.
        using StreamWriter writer = new StreamWriter("eingabe.xml");

        // Der Serializer nimmt die Daten (eingabe) und schreibt sie mit dem StreamWriter.
        serializer.Serialize(writer, eingabe);
    }

    public string Laden()
    {
        // In typeof(string) wird der Typ der Daten angegeben, die deserialisiert werden sollen.
        // In diesem Fall ist es ein einfacher String können aber auch mehrere Datentypen sein.
        XmlSerializer serializer = new XmlSerializer(typeof(string), new Type[] { typeof(int), typeof(double) });

        // Unser Reader der die Datei öffnet und die Daten aus der Datei liest
        // "using" sorgt dafür, dass der StreamReader automatisch geschlossen wird, nachdem er verwendet wurde.
        using StreamReader reader = new StreamReader("eingabe.xml");

        // Der Serializer nimmt die Daten aus dem StreamReader und gibt sie als Objekt zurück, das in diesem Fall in einen String umgewandelt wird.
        return (string)serializer.Deserialize(reader);
    }
    #endregion
}