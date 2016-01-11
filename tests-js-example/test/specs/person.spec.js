var num1 = 2;
var num2 = 2;
var should = require('should');
var Citizen = require('../../citizen');

describe('Citizen', function(){
	describe('Testing Citizen Methods', function(done){
		var willyData = {
            name : "Willy",
            lastName : "Ovalle",
            documentNumber : "00100101010",
            birthDay : new Date(1990, 01, 01),
            sex : 'M'
        };

        var Willy = new Citizen(willyData);

		it('should properly create a citizen object', function(){
			
			Willy.name.should.be.exactly("Willy");
			Willy.lastName.should.be.exactly("Ovalle");
			Willy.documentNumber.should.be.exactly("00100101010");
			(Willy.birthDay == new Date(1990, 01, 01)).should.be.true;
			Willy.sex.should.be.exactly("M");
		});

		it('should have more than 23 years', function(){
			Willy.age().should.be.greaterThan(23);
		});

		it('should be an adult', function(){
			Willy.isAdult().should.be.true;
		});

		it('should throw when invalid sex ', function(){
			(function(){
				Willy.sex = 'Y';	
			}).should.throw();
		});

		it('should throw when invalid documentNumber ', function(){
			(function(){
				Willy.documentNumber = "This is my document Number";
			}).should.throw();
		});

		it('should throw when invalid documentNumber ', function(){
			(function(){
				Willy.documentNumber = "1234567891";
			}).should.throw();
		});

	});
});
