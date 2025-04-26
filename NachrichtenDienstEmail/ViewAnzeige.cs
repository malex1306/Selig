namespace NachrichtenDienstEmail;

public class ViewAnzeige
{
   public void NachrichtAnzeigen(object sender, NachrichtenEventargs e)
   {
      Console.WriteLine($"Anzeige: Neue Nachricht -> {e.Nachricht}");
   }
}