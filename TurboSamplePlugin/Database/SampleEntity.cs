using System.ComponentModel.DataAnnotations.Schema;
using Turbo.Database.Entities;

namespace TurboSamplePlugin.Database;

[Table("sample_entities")]
public class SampleEntity : TurboEntity { }
