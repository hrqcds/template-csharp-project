namespace Models.Dtos;

public class ListUserDto
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }

    public static IEnumerable<ListUserDto> ListUserResponse(List<User> user)
    {
        foreach (var x in user)
        {
            yield return new ListUserDto
            {
                Id = x.Id,
                Name = x.Name,
                CreatedAt = x.CreatedAt,
            };
        }
    }
}