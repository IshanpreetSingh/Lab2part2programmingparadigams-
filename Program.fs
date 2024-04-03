
type Cuisine =
    | Korean
    | Turkish

type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks
    
type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float

let calculateBudget (activity : Activity) : float =
    match activity with
    | BoardGame -> 0.0
    | Chill -> 0.0
    | Movie movieType ->
        match movieType with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (distance, fuelChargePerKm) ->
        float distance * fuelChargePerKm


let movieBudget = calculateBudget (Movie IMAXWithSnacks)
printfn "The budget for the movie is %.2f CAD" movieBudget

let longDriveBudget = calculateBudget (LongDrive (100, 0.15))
printfn "The budget for the long drive is %.2f CAD" longDriveBudget

let restaurantBudget = calculateBudget (Restaurant Korean)
printfn "The budget for the restaurant is %.2f CAD" restaurantBudget
