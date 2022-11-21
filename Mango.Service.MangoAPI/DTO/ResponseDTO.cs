namespace Mango.Service.MangoAPI.DTO
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
