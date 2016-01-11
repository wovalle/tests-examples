function NumbersOperations (){};
NumbersOperations.prototype.Add = function(num1, num2){ return num1 + num2};
NumbersOperations.prototype.Substract = function(num1, num2){ return num1 - num2};
NumbersOperations.prototype.Multiply = function(num1, num2){ return num1 * num2};
NumbersOperations.prototype.Divide = function(num1, num2){ return num1 / num2};

if(module)
	module.exports = NumbersOperations;
