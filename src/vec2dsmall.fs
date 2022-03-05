// Part of the 2d vector library.
// Vectors are represented as floats.
module vec2d

// Calculate the length of a vector.
let len (v : float * float) : float =
    let (x, y) = v
    sqrt(x ** 2.0 + y ** 2.0)


// Calculate the angle of a vector.
let ang (v : float * float) : float =
    let (x, y) = v
    System.Math.Atan2(y, x)


// Add together two vectors.
let add (v1 : float * float) (v2 : float * float) : float * float =
    let (x1, y1) = v1
    let (x2, y2) = v2
    (x1 + x2, y1 + y2)
