namespace FuturArtXTrue;

public partial class ExponatPage : ContentPage
{
    public ExponatPage(String text, String text2, String nachricht, String url)
    {
        InitializeComponent();
        Title.Text = text;
        Title2.Text = text2;
        Message.Text = nachricht;
        Picture.Source = url;
        if (text2 == "")
        {
            Content1.IsVisible = false;
            Content2.IsVisible = true;
        }
        else
        {
            Content1.IsVisible = true;
            Content2.IsVisible = false;
        }
    }
    public ExponatPage()
    {
        InitializeComponent();
        Content2.IsVisible = true;
        Content1.IsVisible = false;
    }
    public void ChangePageExponatSpecific(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage("ZEIT VON DÜRER","BIS BONVICINI","Der Streifzug durch die Geschichte der Zeit vereint Gemälde, Videos und Filme, Installationen, Performances sowie Uhrmacherkunst. Die Werke und Objekte zeugen etwa von der Flüchtigkeit des Lebens, erzählen vom Wechsel der Jahreszeiten und von Möglichkeiten des Innehaltens sowie vom globalen Finanzmarkt, der inzwischen auf Billionstel-Sekunden getaktet wird. Ein vielschichtiger Teppich, der unter anderem historische, paläontologische und physikalische Perspektiven beleuchtet, wird auf über 1200m2 Ausstellungsfläche ausgerollt und gliedert die Schau in sechs Kapitel: Diese befragen unter anderem die sog. «Deep Time», politische Dimensionen und biologische Aspekte von Zeit. Des Weiteren laden partizipative Formate dazu ein, sich über innovative Zukunftsmodelle auszutauschen: Ein so reizvolles wie dringliches Angebot, wird gesellschaftlich unentwegt darüber debattiert, wie es zukünftig noch möglich sei, das Überleben des Planeten und seiner Bewohner:innen zu sichern – und wie viel Zeit uns dafür noch bleibe.","kunst3.png");
    }
    public void ChangePageExponatSpecificSternenNacht(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage("DIE STERNENNACHT","MIT SCHWUNG","\"Sternennacht\" von Vincent van Gogh, geschaffen im Jahr 1889, ist zweifellos eines der eindrucksvollsten Gemälde des niederländischen Künstlers. Dieses Meisterwerk fängt die Essenz von van Goghs kreativer Leidenschaft und seiner einzigartigen Vorstellungskraft ein.\n\nDas Gemälde präsentiert eine nächtliche Szene, in der ein Dorf unter einem wirbelnden Himmel aus Sternen liegt. Van Gogh verwendet intensive Farben und kräftige Pinselstriche, um eine lebendige Darstellung zu schaffen, die die Landschaft in einen magischen, fast träumerischen Zustand versetzt. Die Sterne am Himmel pulsieren förmlich vor Energie, und die Wirbel und Linien verleihen dem Bild eine dynamische Bewegung.\n\nVan Goghs einzigartiger Stil, der als Post-Impressionismus bekannt ist, manifestiert sich in \"Sternennacht\" durch die Verwendung von expressiven Farben und dem Verzicht auf realistische Details. Der Künstler schuf ein Werk, das nicht nur die physische Realität einfängt, sondern auch seine eigene emotionale und spirituelle Wahrnehmung der Welt widerspiegelt.\n\nDer Blick auf \"Sternennacht\" lässt uns in die Psyche van Goghs eintauchen, der während der Entstehung dieses Gemäldes in einer psychiatrischen Anstalt war. Die Kombination von intensiven Farben und einer fast chaotischen Darstellung des Himmels vermittelt einen Eindruck von innerer Turbulenz und gleichzeitig von ästhetischem Genie.\n\nDieses Exponat lädt dazu ein, sich von der Magie und der Einzigartigkeit von van Goghs Schaffen verzaubern zu lassen. \"Sternennacht\" bleibt ein zeitloses Beispiel für die transformative Kraft der Kunst und die Fähigkeit des Künstlers, die Schönheit des Universums auf unvergleichliche Weise zu interpretieren.","kunst1.png");
    }
    public void ChangePageExponatSpecificSchrei(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage("DER SCHREI","DER NACHKLINGT","\"Der Schrei\" von Edvard Munch, geschaffen im Jahr 1893, ist ein Schlüsselwerk der symbolistischen Bewegung und verkörpert die Essenz des existentialistischen Ausdrucks.\n\nDas Gemälde zeigt eine schemenhafte Figur auf einer Brücke, umgeben von einer verzerrten Landschaft. Zerrissene Wolken und ein leuchtend roter Himmel verstärken das Gefühl der Verzweiflung. Das entstellte Gesicht der Figur und die weit aufgerissenen Augen vermitteln einen stummen Schrei, der Munchs persönliche Krise widerspiegelt und gleichzeitig eine universelle Erfahrung anspricht.\n\nDie kräftigen Farben intensivieren die emotionalen Turbulenzen, während Munchs künstlerische Technik dazu beiträgt, die innere Zerrissenheit der Figur zu vermitteln. \"Der Schrei\" ist nicht nur ein individueller Ausdruck von Munchs inneren Kämpfen, sondern auch ein Spiegelbild der Unsicherheiten und Ängste in der damaligen Gesellschaft.\n\nDieses Exponat lädt dazu ein, in die tiefen Abgründe der menschlichen Seele zu blicken und sich mit den existenziellen Fragen auseinanderzusetzen, die auch heute noch aktuell sind. \"Der Schrei\" von Edvard Munch bleibt ein kraftvolles Zeugnis für die menschliche Existenz und ihre existenziellen Herausforderungen.","kunst2.png");
    }
    public void ChangePageExponatSpecificHase(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExponatPage("DER FELDHASE","RUHEND","\"Feldhase\" von Albrecht Dürer, erschaffen im Jahr 1502, ist ein beeindruckendes Beispiel für die detailgetreue Darstellung von Natur in der Kunst der Renaissance. Dieses Meisterwerk des deutschen Künstlers fängt die Anmut und Schönheit eines einfachen Feldhasen in einer präzisen und realistischen Weise ein.\n\nDas Gemälde zeigt den Feldhasen inmitten einer natürlichen Umgebung, mit dichtem, lebendigem Fell und wachsamen Augen. Dürers meisterhafte Beherrschung der Gravurtechnik ermöglichte es ihm, jedes einzelne Haar und jede Kontur des Hasen in erstaunlicher Detailgenauigkeit zu erfassen. Der Hase scheint lebendig, als könnte er jeden Moment in die Wildnis springen.\n\nDürers \"Feldhase\" repräsentiert nicht nur die handwerkliche Virtuosität des Künstlers, sondern auch seine tiefgreifende Wertschätzung für die Natur. Der Hase wird nicht als bloßes Tier dargestellt, sondern als lebendiges Wesen mit eigener Persönlichkeit und Charakter.\n\nDieses Kunstwerk lädt dazu ein, sich in die feinen Nuancen der Natur zu vertiefen und die Meisterschaft Dürers in der realistischen Darstellung zu bewundern. Es erinnert uns daran, dass Kunst nicht nur die Schönheit der Welt widerspiegeln kann, sondern auch die Fähigkeit des Künstlers, sie in ihrer ganzen Pracht festzuhalten. \"Feldhase\" bleibt ein zeitloses Beispiel für die Kunst der Präzision und die tiefe Verbindung zwischen Künstler und Natur.","hase.png");
    }
}