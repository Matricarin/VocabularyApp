namespace DomainLayer.Models.Vocabulary
{
    public interface IVocabularyModel
    {
        string EngWord { get; set; }
        string PartOfSpeech { get; set; }
        string RusWord { get; set; }
        int WordId { get; set; }
    }
}