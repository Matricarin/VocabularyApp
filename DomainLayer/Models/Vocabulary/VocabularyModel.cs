using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Vocabulary
{
    public class VocabularyModel : IVocabularyModel
    {
        public int WordId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "English word is required field.")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Word or phrase must be between 3 and 40 characters")]
        public string EngWord { get; set; }
        [Required(ErrorMessage = "Part of speech is required field.")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Must be abbreviation of the part of speech")]
        [RegularExpression(@"(n|v|adj|prep|adv|pron|conj)", ErrorMessage = "Incorrect format")]
        public string PartOfSpeech { get; set; }
        [Required(ErrorMessage = "Russian word is required field.")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Word or phrase must be between 3 and 40 characters")]
        public string RusWord { get; set; }
    }
}
