/// A 2 dimensional vector library .
/// Vectors are represented as pairs of floats
module vec2d

/// The length of a vector
val len : float * float -> float
///<summary>len value to calculate length of vector</summary>
///<remarks>Only floats are accepted</remarks>
///<param name ="v">Input vector</param>
///<returns>The length of a vector</returns>

/// The angle of a vector
val ang : float * float -> float
///<summary>ang value to calculate angle of vector</summary>
///<remarks>Only floats are accepted</remarks>
///<param name ="v">Input vector</param>
///<returns>The angle of a vector</returns>

/// Addition of two vectors
val add : float * float -> float * float -> float * float
///<summary>add value to calculate sum of vectors</summary>
///<remarks>Only floats are accepted</remarks>
///<param name ="v1">First input vector</param>
///<param name ="v2">Second input vector</param>
///<returns>The sum of two vectors</returns>