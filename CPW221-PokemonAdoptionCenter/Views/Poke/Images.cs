namespace CPW221_PokemonAdoptionCenter.Views.Poke
{
    public class Images
    {
        public async Task<byte[]> GetByteArrayFromImage(IFormFile image)
        {
            using (var memoryStream = new MemoryStream())
            {
                await image.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
