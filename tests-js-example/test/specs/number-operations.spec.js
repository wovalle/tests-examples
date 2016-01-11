var num1 = 2;
var num2 = 2;

var NumbersOperations = require('../../number-operations');
var numbersOperations = new NumbersOperations();

describe('Numbers', function(){
	describe('Testing Number Methods', function(done){
		it('should add two numbers', function(){
			numbersOperations.Add(num1, num2).should.be.exactly(4);
		});

		it('should substract two numbers', function(){
			numbersOperations.Substract(num1, num2).should.be.exactly(0);
		});
		it('should multiply two numbers', function(){
			numbersOperations.Multiply(num1, num2).should.be.exactly(4);
		});

		it('should divide two numbers', function(){
			numbersOperations.Divide(num1, num2).should.be.exactly(1);
		});
	});
});
