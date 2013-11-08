describe("FizzBuzz",function(){
 it("1 should be output 1",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.go(1)).toBe(1);
 });
 it("3 should be output Fizz",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.go(3)).toBe("FizzFizz");
 });
 it("5 should be output Buzz",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.go(5)).toBe("BuzzBuzz");
 });

 it("7 should be output Woof",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.go(7)).toBe("WoofWoof");
 });

it("7 should be output Woof",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.go(35)).toBe("WoofWoof");
 });

 it("15 should be output FizzBuzz",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.go(15)).toBe("FizzBuzzBuzz");
 });
 it("1 should be output <li>1</li>",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.goWithFormat(1)).toBe("<li>1</li>");
 });
 xit("1-100 should be output <li>1</li>...",function(){
 	var fizzBuzz=new FizzBuzz();
 	expect(fizzBuzz.goWithLoop(1,100)).toBe("<li>1</li><li>2</li><li>Fizz</li><li>4</li><li>Buzz</li><li>Fizz</li><li>7</li><li>8</li><li>Fizz</li><li>Buzz</li><li>11</li><li>Fizz</li><li>13</li><li>14</li><li>FizzBuzz</li><li>16</li><li>17</li><li>Fizz</li><li>19</li><li>Buzz</li><li>Fizz</li><li>22</li><li>23</li><li>Fizz</li><li>Buzz</li><li>26</li><li>Fizz</li><li>28</li><li>29</li><li>FizzBuzz</li><li>31</li><li>32</li><li>Fizz</li><li>34</li><li>Buzz</li><li>Fizz</li><li>37</li><li>38</li><li>Fizz</li><li>Buzz</li><li>41</li><li>Fizz</li><li>43</li><li>44</li><li>FizzBuzz</li><li>46</li><li>47</li><li>Fizz</li><li>49</li><li>Buzz</li><li>Fizz</li><li>52</li><li>53</li><li>Fizz</li><li>Buzz</li><li>56</li><li>Fizz</li><li>58</li><li>59</li><li>FizzBuzz</li><li>61</li><li>62</li><li>Fizz</li><li>64</li><li>Buzz</li><li>Fizz</li><li>67</li><li>68</li><li>Fizz</li><li>Buzz</li><li>71</li><li>Fizz</li><li>73</li><li>74</li><li>FizzBuzz</li><li>76</li><li>77</li><li>Fizz</li><li>79</li><li>Buzz</li><li>Fizz</li><li>82</li><li>83</li><li>Fizz</li><li>Buzz</li><li>86</li><li>Fizz</li><li>88</li><li>89</li><li>FizzBuzz</li><li>91</li><li>92</li><li>Fizz</li><li>94</li><li>Buzz</li><li>Fizz</li><li>97</li><li>98</li><li>Fizz</li><li>Buzz</li>");
 });
})
