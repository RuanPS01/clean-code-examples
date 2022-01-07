//Exemplo superficial em JS
// Sem injeção de dependência
var Foo = function() {
	this.bar = new Bar();
}
var foo = new Foo();

// Com injeção de dependência
var Foo = function(bar) {
	this.bar = bar;
}