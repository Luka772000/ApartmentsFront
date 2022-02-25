

export class Member{
    id:number;
    userName:string;
    age:number;
    userRole:number;
    phoneNumber:number;
    cards:Card[]


}
export class UUser{
    id:number=0;
    userName:string="";
    age:number= 0;
    userRole:number=0;
    phoneNumber:number=0;
    cardId:number=0;
    cards:Card[]
    contracts: Contract[]
    apartments: Apartment[]
}

export  interface Card{
    id:number,
    name:string,
    cardNumber:number,
    cvc:number,
    date:number
}
export interface Contract{
    userId: number,
    apartmentId: number
}
export class Apartment{
    id: number=0;
    apartmentDescription: string="";
    numberOfRooms: number=0;
    monthlyPrice: number=0;
    adressId:number=0;
    adress: Adress
    contract: Contract[]
}
export interface Adress{
    id: number,
    streetName: string,
    buildingNumber: number,
    apartmentNumber: number,
    apartment: Apartment[]
}