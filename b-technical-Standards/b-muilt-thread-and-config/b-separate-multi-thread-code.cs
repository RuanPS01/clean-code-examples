public async Task<IEnumerable<Model>> GetAsync()
{
    var model = new Model();
    model.Courses = await _context.Courses.ToListAsync();
    model.Tags = _context.Courses.ToList(); // Não async
    
    return model;
}