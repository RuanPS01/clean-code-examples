//Evite
[HttpGet("cursos")]
public IActionResult Index([FromServices] IContentRepository repository)
{
    ViewBag.Courses = repository.GetContents(EContentType.Course);
    return View();
}

ou 

//Evite Extra
public IActionResult Index([FromServices] IContentRepository repository)
{
		ViewBag.Courses = repository.GetContentsAsync(EContentType.Course).then = function(){
			return View();
		}.catch = function(error){
			return error;
		};
}


//UTILIZE
[HttpGet("cursos")]
public async Task<IActionResult> Index([FromServices] IContentRepository repository)
{
    ViewBag.Courses = await repository.GetContentsAsync(EContentType.Course);
    return View();
}