import Child from "./Child";

export default class User{
    constructor(public firstName:string,public lastName:string,public IdNumber:string,public DateOfBirth:Date,public gender:number,public Hmo:string,public children:Child[]){}
}