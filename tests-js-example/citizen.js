var Citizen = function (citizen){
	this.id = citizen.id || '';
	this.name = citizen.name || '';
	this.lastName = citizen.lastName || '';
	this._documentNumber = citizen.documentNumber || '';
	this._sex = citizen.sex || '';
	this._birthDay = citizen.birthDay || '';

	this.sexType = {
		male : 'm',
		female : 'f'
	};
};

Object.defineProperty(Citizen.prototype, "sex", {
	  get: function() {return this._sex; },
	  set: function(value) { 

	  	if(!~['M', 'F'].indexOf(value.toUpperCase()))
	  		throw 'Invalid sex';
	  	else
	  		this._sex = value;
	  }
});

Object.defineProperty(Citizen.prototype, "documentNumber", {
	  get: function() {return this._documentNumber; },
	  set: function(value) { 

	  	if(!value)
	  		throw 'Invalid blank document number';
	  	else if (value.length > 11)
	  		throw 'Document number cannot have more than 11 characters';
	  	else if (value.length < 11)
	  		throw 'Document number cannot have less than 11 characters';
	  	else if (/[a-zA-Z]/.test(value))
	  		throw 'Invalid document number';
	  	else
	  		this._documentNumber = value;
	  }
});

//The best thing to do here is to use a library like momentjs to parse dates, but this would do 
Object.defineProperty(Citizen.prototype, "birthDay", {
	  get: function() {return this._birthDay; },
	  set: function(value) {
	  	if(value instanceof Date) 
	  		this._birthDay = value;
	  	else
	  		throw 'Invalid date';
	  		
	  }
});

//Async function
Citizen.prototype.save = function(callback){
	//*insert into the db here*
	this.id = newGuid();
	callback(true);
};

Citizen.prototype.age = function(){
    var ageDifMs = Date.now() - this.birthDay.getTime();
    var ageDate = new Date(ageDifMs); // miliseconds from epoch
    return Math.abs(ageDate.getUTCFullYear() - 1970);
};

Citizen.prototype.isAdult = function(){
    return this.age() > 18;
};

//http://stackoverflow.com/questions/105034/create-guid-uuid-in-javascript
var newGuid = function() {
  function s4() {
    return Math.floor((1 + Math.random()) * 0x10000)
      .toString(16)
      .substring(1);
  };
  return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
    s4() + '-' + s4() + s4() + s4();
};

if(module)
	module.exports = Citizen;