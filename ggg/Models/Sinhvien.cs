using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ggg.Models;
public class Sinhvien 
{
    [Key]
    public string masv {get;set;}
    public string hoten {get;set;}
    public string malop {get;set;}
    [ForeignKey("malop")]
    public Lophoc? Lophoc {get;set;}

    public string diachi {get;set;}


}