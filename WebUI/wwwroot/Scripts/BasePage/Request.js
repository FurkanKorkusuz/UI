// Request
class Request {

    GetAll = false;
    RowNumber = 0;
    RowPerPage = 30;
    TopRow = 0;
    OrderBy = [new RequestOrderBy()];
    Filter = [new RequestFilter()];

    //constructor(name) {
    //    this.name = name;
    //}

    //introduceSelf() {
    //    alert(`Hi! I'm ${this.name}`);
    //}

}

class RequestOrderBy {
    OrderByColumn = "ID"
    IsAscending = true;
}

class RequestFilter {
    FilterKey = "";
    FilterValue = "";
    ConditionOperator = ConditionOperator.Equals;
}

class ConditionOperator {
    Equals = 0;
    EqualsNot = 1;

    Bigger = 2;
    Smaller = 3;

    EqBigger = 4;
    EqSmaller = 5;

    In = 6;
    NotIn = 7;

    Like = 8;
    NotLike = 9;


    //IsNot,
    //Is
}



