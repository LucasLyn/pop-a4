// I difine 2 vectors to use
let mutable v1 = (1.2, 5.3)
let mutable v2 = (2.8, 4.2)


// Compares floats and returns true if the difference it small enough.
let compareFloat (x : float) (y : float) : bool =
    System.Math.Abs(x - y) < 0.01


// Print Black-box test of vec2d library.'
// 1st box in library used, 2nd is the input used for each value,
// 3rd is the expected output, and 4th is the case explained shortly.
// First line corresponds to the 4 boxes, the line below shows
// the actual output of the library.
printfn "Case | Exp. Output"
printfn "__________________"
printfn "v1 = %A | 5.43 & 77.24" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 5.43)
        (compareFloat (vec2d.ang v1) 77.24)
printfn ""

v1 <- (-1.2, 5.3)
printfn "v1 = %A | 5.43 & -77.24" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 5.43)
        (compareFloat (vec2d.ang v1) -77.24)
printfn ""

v1 <- (1.2, -5.3)
printfn "v1 = %A | 5.43 & 102.75" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 5.43)
        (compareFloat (vec2d.ang v1) 102.75)
printfn ""

v1 <- (-1.2, -5.3)
printfn "v1 = %A | 5.43 & -102.75" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 5.43)
        (compareFloat (vec2d.ang v1) -102.75)
printfn ""

v1 <- (0.0, 5.3)
printfn "v1 = %A | 5.30 & 0.00" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 5.30)
        (compareFloat (vec2d.ang v1) 0.00)
printfn ""

v1 <- (1.2, 0.0)
printfn "v1 = %A | 1.20 & 1.57" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 1.20)
        (compareFloat (vec2d.ang v1) 1.57)
printfn ""

v1 <- (0.0, 0.0)
printfn "v1 = %A | 0.00 & 0.00" v1
printfn "Output: | vec2d.len: %A & vec2d.ang: %A" (vec2d.len v1) (vec2d.ang v1)
printfn "len: %A | ang: %A" (compareFloat (vec2d.len v1) 0.00)
        (compareFloat (vec2d.ang v1) 0.00)
printfn ""

v1 <- (1.2, 5.3)
v2 <- (2.8, 4.2)
printfn "v1 = %A & v2 = %A | (4.0, 9.5)" v1 v2
printfn "Output: | vec2d.add: %A" (vec2d.add v1 v2)
printfn "add: %A" (vec2d.add v1 v2 = (4.0, 9.5))
printfn ""

v1 <- (1.2, -5.3)
v2 <- (2.8, 4.2)
printfn "v1 = %A & v2 = %A | (4.0, -1.1)" v1 v2
printfn "Output: | vec2d.add: %A" (vec2d.add v1 v2)
let mutable tmp = (vec2d.add v1 v2)
printfn"add: %A" ((compareFloat (fst tmp) 4.0) && (compareFloat (snd tmp) -1.1))
printfn ""

v1 <- (-1.2, 5.3)
v2 <- (2.8, 4.2)
printfn "v1 = %A & v2 = %A | (1.6, 9.5)" v1 v2
printfn "Output: | vec2d.add: %A" (vec2d.add v1 v2)
tmp <- (vec2d.add v1 v2)
printfn "add: %A" ((compareFloat (fst tmp) 1.6) && (compareFloat (snd tmp) 9.5))
printfn ""

v1 <- (0.0, 0.0)
v2 <- (2.8, 4.2)
printfn "v1 = %A & v2 = %A | (2.8, 4.2)" v1 v2
printfn "Output: | vec2d.add: %A" (vec2d.add v1 v2)
printfn "add: %A" (vec2d.add v1 v2 = (2.8, 4.2))
printfn ""

v1 <- (0.0, 0.0)
v2 <- (0.0, 0.0)
printfn "v1 = %A & v2 = %A | (0.0, 0.0)" v1 v2
printfn "Output: | vec2d.add: %A" (vec2d.add v1 v2)
printfn "add: %A" (vec2d.add v1 v2 = (0.0, 0.0))
printfn ""




// The Black-box test did generally as I was expecting.
// The simple vector operations such as finding the length
// and adding two vectors together worked flawlessly,
// regardless of input.
// The only problem were the angles.
// The angles were seemingly calculated as radians
// and not regular degrees. This results in a different output.
// A fix for this could be a function converting radians to degrees.
// Additionally, the vec2d.add function cannot correctly compare floats
// if there is a negative float involved. Thus, the variable tmp was created,
// to then be used in a more advanced compareFloat call.