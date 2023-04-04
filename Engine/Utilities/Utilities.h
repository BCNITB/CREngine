#pragma once

#define USE_STL_VECTOR 1
#define USE_STL_DEQUE 1

#if USE_STL_VECTOR
#include <vector>
namespace cre::utl {
	template<typename T>
	using vector = typename std::vector<T>;
}
#else

#endif

#if USE_STL_DEQUE
#include <deque>
namespace cre::utl {
	template<typename T>
	using deque = typename std::deque<T>;
}
#else

#endif

namespace cre::utl {

	// TODO: implement our own containers
}