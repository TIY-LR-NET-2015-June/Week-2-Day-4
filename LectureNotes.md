# Week-2-Day-4

## Have the students do Challenge #1

## Lecture - History
1. Waterfall (http://www.waterfall-model.com/) 
	- Know all requirements up front
	- Developer team separated from the business team
	- Only communicate once product is finished and in testing phase
	- Only deployable at the end of the project
2. Agile (http://www.waterfall-model.com/agile-software-development-part-1/)
	- Iterative approach
	- Close collaboration between the developers and business experts
	- Constantly adding value (deployable)
3. How to test and why should you care?
	- Unit test - confirms functionality of a small unit of work or component in a larger system
	- Idea is to help document requirements in application via the unit tests

## Have the students do Challenge #2

##Demo the console application used as a testing harness
- Animals with bark, etc.
	- Create Dog class in the Animal namespace with Bark method
	- Use main application to test to see if 1

## Discuss why using a console application to test is not as good as a unit test framework
	- Able to automate testing during continuous integration step (build)
	- Easier to track each test and the expected result

##Unit test framework vs Console Application
- Nunit
- Xunit
- MSTest
- Others

##Show how to use a test framework (MSTest)
Using same Animal concept but with new "DLL" project and UnitTest project in 1 solution
1. Create new dll project
2. Create new tests project in same solution
3. Add reference to dll project
4. Rename the UnitTest1.cs file to : **When_telling_a_dog_to_bark**
	Add the following tests
		- The_dog_barks_once_for_1_treat
		- The_dog_does_not_bark_for_0_treats

##Discuss what unit tests you might want to add to test Challenge #1

##Ask the students to now create a unit test for challenge #1
- add a unit test project to their challenge #1 solution
- create a unit test

##Discuss what unit tests you might want to add to test Challenge #2

##Ask the students to now create a unit test for challenge #2
- add a unit test project to their challnege #2 solution

##Go over the code for the Rock Paper Scissors program and see if they have any questions.

##If time permits
- Talk about TDD 
	1. Create a failing tests (RED)
	2. Make the test pass (GREEN)
	3. Refactor (improve the initial implementation without changing the external contract or behavior)
- Show the [https://www.youtube.com/watch?v=xFGFk0Fnztg](Bowling Game Kata Video) or do the Kata with the PowerPoint slides

##Be aware of [http://david.heinemeierhansson.com/2014/test-induced-design-damage.html](Test-induced design damage) when using TDD