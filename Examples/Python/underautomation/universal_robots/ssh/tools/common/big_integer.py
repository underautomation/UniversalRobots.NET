import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import BigInteger as big_integer

class BigInteger:
	def __init__(self, value: int, _internal = 0):
		if(_internal == 0):
			self._instance = big_integer(value)
		else:
			self._instance = _internal
	@staticmethod
	def mod_inverse(bi: 'BigInteger', modulus: 'BigInteger') -> 'BigInteger':
		return big_integer.ModInverse(bi._instance, modulus._instance)
	@staticmethod
	def positive_mod(dividend: 'BigInteger', divisor: 'BigInteger') -> 'BigInteger':
		return big_integer.PositiveMod(dividend._instance, divisor._instance)
	@staticmethod
	def random(bitLength: int) -> 'BigInteger':
		return big_integer.Random(bitLength)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> int:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> float:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> float:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__explicit(value: 'BigInteger') -> float:
		return big_integer.op_Explicit(value._instance)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'BigInteger':
		return big_integer.op_Implicit(value)
	@staticmethod
	def op__explicit(value: float) -> 'BigInteger':
		return big_integer.op_Explicit(value)
	@staticmethod
	def op__explicit(value: float) -> 'BigInteger':
		return big_integer.op_Explicit(value)
	@staticmethod
	def op__explicit(value: float) -> 'BigInteger':
		return big_integer.op_Explicit(value)
	@staticmethod
	def op__addition(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Addition(left._instance, right._instance)
	@staticmethod
	def op__subtraction(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Subtraction(left._instance, right._instance)
	@staticmethod
	def op__multiply(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Multiply(left._instance, right._instance)
	@staticmethod
	def op__division(dividend: 'BigInteger', divisor: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Division(dividend._instance, divisor._instance)
	@staticmethod
	def op__modulus(dividend: 'BigInteger', divisor: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Modulus(dividend._instance, divisor._instance)
	@staticmethod
	def op__unary_negation(value: 'BigInteger') -> 'BigInteger':
		return big_integer.op_UnaryNegation(value._instance)
	@staticmethod
	def op__unary_plus(value: 'BigInteger') -> 'BigInteger':
		return big_integer.op_UnaryPlus(value._instance)
	@staticmethod
	def op__increment(value: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Increment(value._instance)
	@staticmethod
	def op__decrement(value: 'BigInteger') -> 'BigInteger':
		return big_integer.op_Decrement(value._instance)
	@staticmethod
	def op__bitwise_and(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.op_BitwiseAnd(left._instance, right._instance)
	@staticmethod
	def op__bitwise_or(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.op_BitwiseOr(left._instance, right._instance)
	@staticmethod
	def op__exclusive_or(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.op_ExclusiveOr(left._instance, right._instance)
	@staticmethod
	def op__ones_complement(value: 'BigInteger') -> 'BigInteger':
		return big_integer.op_OnesComplement(value._instance)
	@staticmethod
	def op__left_shift(value: 'BigInteger', shift: int) -> 'BigInteger':
		return big_integer.op_LeftShift(value._instance, shift)
	@staticmethod
	def op__right_shift(value: 'BigInteger', shift: int) -> 'BigInteger':
		return big_integer.op_RightShift(value._instance, shift)
	@staticmethod
	def op__less_than(left: 'BigInteger', right: 'BigInteger') -> bool:
		return big_integer.op_LessThan(left._instance, right._instance)
	@staticmethod
	def op__less_than(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_LessThan(left._instance, right)
	@staticmethod
	def op__less_than(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_LessThan(left, right._instance)
	@staticmethod
	def op__less_than(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_LessThan(left._instance, right)
	@staticmethod
	def op__less_than(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_LessThan(left, right._instance)
	@staticmethod
	def op__less_than_or_equal(left: 'BigInteger', right: 'BigInteger') -> bool:
		return big_integer.op_LessThanOrEqual(left._instance, right._instance)
	@staticmethod
	def op__less_than_or_equal(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_LessThanOrEqual(left._instance, right)
	@staticmethod
	def op__less_than_or_equal(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_LessThanOrEqual(left, right._instance)
	@staticmethod
	def op__less_than_or_equal(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_LessThanOrEqual(left._instance, right)
	@staticmethod
	def op__less_than_or_equal(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_LessThanOrEqual(left, right._instance)
	@staticmethod
	def op__greater_than(left: 'BigInteger', right: 'BigInteger') -> bool:
		return big_integer.op_GreaterThan(left._instance, right._instance)
	@staticmethod
	def op__greater_than(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_GreaterThan(left._instance, right)
	@staticmethod
	def op__greater_than(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_GreaterThan(left, right._instance)
	@staticmethod
	def op__greater_than(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_GreaterThan(left._instance, right)
	@staticmethod
	def op__greater_than(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_GreaterThan(left, right._instance)
	@staticmethod
	def op__greater_than_or_equal(left: 'BigInteger', right: 'BigInteger') -> bool:
		return big_integer.op_GreaterThanOrEqual(left._instance, right._instance)
	@staticmethod
	def op__greater_than_or_equal(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_GreaterThanOrEqual(left._instance, right)
	@staticmethod
	def op__greater_than_or_equal(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_GreaterThanOrEqual(left, right._instance)
	@staticmethod
	def op__greater_than_or_equal(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_GreaterThanOrEqual(left._instance, right)
	@staticmethod
	def op__greater_than_or_equal(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_GreaterThanOrEqual(left, right._instance)
	@staticmethod
	def op__equality(left: 'BigInteger', right: 'BigInteger') -> bool:
		return big_integer.op_Equality(left._instance, right._instance)
	@staticmethod
	def op__equality(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_Equality(left._instance, right)
	@staticmethod
	def op__equality(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_Equality(left, right._instance)
	@staticmethod
	def op__equality(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_Equality(left._instance, right)
	@staticmethod
	def op__equality(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_Equality(left, right._instance)
	@staticmethod
	def op__inequality(left: 'BigInteger', right: 'BigInteger') -> bool:
		return big_integer.op_Inequality(left._instance, right._instance)
	@staticmethod
	def op__inequality(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_Inequality(left._instance, right)
	@staticmethod
	def op__inequality(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_Inequality(left, right._instance)
	@staticmethod
	def op__inequality(left: 'BigInteger', right: int) -> bool:
		return big_integer.op_Inequality(left._instance, right)
	@staticmethod
	def op__inequality(left: int, right: 'BigInteger') -> bool:
		return big_integer.op_Inequality(left, right._instance)
	def equals(self, obj: typing.Any) -> bool:
		return self._instance.Equals(obj)
	def equals(self, other: 'BigInteger') -> bool:
		return self._instance.Equals(other._instance)
	def equals(self, other: int) -> bool:
		return self._instance.Equals(other)
	def __repr__(self):
		return self._instance.ToString()
	def to_string(self, format: str) -> str:
		return self._instance.ToString(format)
	def to_string(self, provider: typing.Any) -> str:
		return self._instance.ToString(provider)
	def to_string(self, format: str, provider: typing.Any) -> str:
		return self._instance.ToString(format, provider)
	@staticmethod
	def parse(value: str) -> 'BigInteger':
		return big_integer.Parse(value)
	@staticmethod
	def parse(value: str, style: typing.Any) -> 'BigInteger':
		return big_integer.Parse(value, style)
	@staticmethod
	def parse(value: str, provider: typing.Any) -> 'BigInteger':
		return big_integer.Parse(value, provider)
	@staticmethod
	def parse(value: str, style: typing.Any, provider: typing.Any) -> 'BigInteger':
		return big_integer.Parse(value, style, provider)
	@staticmethod
	def try_parse(value: str, result: 'BigInteger') -> bool:
		return big_integer.TryParse(value, result._instance)
	@staticmethod
	def try_parse(value: str, style: typing.Any, provider: typing.Any, result: 'BigInteger') -> bool:
		return big_integer.TryParse(value, style, provider, result._instance)
	@staticmethod
	def min(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.Min(left._instance, right._instance)
	@staticmethod
	def max(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.Max(left._instance, right._instance)
	@staticmethod
	def abs(value: 'BigInteger') -> 'BigInteger':
		return big_integer.Abs(value._instance)
	@staticmethod
	def div_rem(dividend: 'BigInteger', divisor: 'BigInteger', remainder: 'BigInteger') -> 'BigInteger':
		return big_integer.DivRem(dividend._instance, divisor._instance, remainder._instance)
	@staticmethod
	def pow(value: 'BigInteger', exponent: int) -> 'BigInteger':
		return big_integer.Pow(value._instance, exponent)
	@staticmethod
	def mod_pow(value: 'BigInteger', exponent: 'BigInteger', modulus: 'BigInteger') -> 'BigInteger':
		return big_integer.ModPow(value._instance, exponent._instance, modulus._instance)
	@staticmethod
	def greatest_common_divisor(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.GreatestCommonDivisor(left._instance, right._instance)
	@staticmethod
	def log(value: 'BigInteger', baseValue: float) -> float:
		return big_integer.Log(value._instance, baseValue)
	@staticmethod
	def log(value: 'BigInteger') -> float:
		return big_integer.Log(value._instance)
	@staticmethod
	def log10(value: 'BigInteger') -> float:
		return big_integer.Log10(value._instance)
	def equals(self, other: int) -> bool:
		return self._instance.Equals(other)
	def get_hash_code(self) -> int:
		return self._instance.GetHashCode()
	@staticmethod
	def add(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.Add(left._instance, right._instance)
	@staticmethod
	def subtract(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.Subtract(left._instance, right._instance)
	@staticmethod
	def multiply(left: 'BigInteger', right: 'BigInteger') -> 'BigInteger':
		return big_integer.Multiply(left._instance, right._instance)
	@staticmethod
	def divide(dividend: 'BigInteger', divisor: 'BigInteger') -> 'BigInteger':
		return big_integer.Divide(dividend._instance, divisor._instance)
	@staticmethod
	def remainder(dividend: 'BigInteger', divisor: 'BigInteger') -> 'BigInteger':
		return big_integer.Remainder(dividend._instance, divisor._instance)
	@staticmethod
	def negate(value: 'BigInteger') -> 'BigInteger':
		return big_integer.Negate(value._instance)
	def compare_to(self, obj: typing.Any) -> int:
		return self._instance.CompareTo(obj)
	def compare_to(self, other: 'BigInteger') -> int:
		return self._instance.CompareTo(other._instance)
	def compare_to(self, other: int) -> int:
		return self._instance.CompareTo(other)
	def compare_to(self, other: int) -> int:
		return self._instance.CompareTo(other)
	@staticmethod
	def compare(left: 'BigInteger', right: 'BigInteger') -> int:
		return big_integer.Compare(left._instance, right._instance)
	def to_byte_array(self) -> typing.List[int]:
		return self._instance.ToByteArray()
	@property
	def bit_length(self) -> int:
		return self._instance.BitLength
	@property
	def is_even(self) -> bool:
		return self._instance.IsEven
	@property
	def is_one(self) -> bool:
		return self._instance.IsOne
	@property
	def is_power_of_two(self) -> bool:
		return self._instance.IsPowerOfTwo
	@property
	def is_zero(self) -> bool:
		return self._instance.IsZero
	@property
	def sign(self) -> int:
		return self._instance.Sign
	@property
	def minus_one(self) -> 'BigInteger':
		return BigInteger(None, self._instance.MinusOne)
	@property
	def one(self) -> 'BigInteger':
		return BigInteger(None, self._instance.One)
	@property
	def zero(self) -> 'BigInteger':
		return BigInteger(None, self._instance.Zero)
