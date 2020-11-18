# Svelto Entity Component System 3.0 BETA

=====================================

Real ECS framework for c\#. Enables to write encapsulated, decoupled, maintainable, highly efficient, data oriented, cache friendly, multi-threaded (if used with Svelto.Tasks), code without pain. Although the framework is platform agnostic \(compatible with c\# 7 and .net standard 2.0\), it comes with several Unity extensions.

## Why using Svelto.ECS with Unity?

_Svelto.ECS wasn't born just from the needs of a large team, but also as result of years of reasoning behind software engineering applied to game development\(\*\). Compared to Unity.ECS, the main goals and reasons for Svelto.ECS to exist are different enough to justify its on going development \(plus Svelto is platform agnostic, so it has been written with portability in mind\). Svelto.ECS hasn't been written just to develop faster code, it has been built to help develop better code. Performance gain is one of the benefits in using Svelto.ECS, as ECS in general is a great way to write cache-friendly code. However Svelto.ECS has been designed around the shift of paradigm from Object Oriented Programming and the consequent improvement of the code design and maintainability. Svelto.ECS is the result of years of iteration of the ECS paradigm applied to real game development with the intent to be "junior coder proof"._

## How to clone the repository:
The folders Svelto.ECS, Svelto.Tasks and Svelto.Common, where present, are submodules pointing to the relative repositories. If you find them empty, you need to update them through the submodule command. Check some instructions here: https://github.com/sebas77/Svelto.ECS.Vanilla.Example/wiki

## Svelto is now distributed as Unity Package too [![openupm](https://img.shields.io/npm/v/com.sebaslab.svelto.ecs?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.sebaslab.svelto.ecs/)

read this article for more information:http://www.sebaslab.com/distributing-svelto-through-openupm/

## Official Examples

### * **Mini Examples**: [https://github.com/sebas77/Svelto.MiniExamples](https://github.com/sebas77/Svelto.MiniExamples) \(including articles\)
* **Unity Boids Simulation**: [https://github.com/sebas77/Svelto.ECS.Examples.Boids](https://github.com/sebas77/Svelto.ECS.Examples.Boids) \(including article\)
* **Unit Tests**: [https://github.com/sebas77/Svelto.ECS.Tests](https://github.com/sebas77/Svelto.ECS.Tests)

**Official Chat \(join to get help from me for free!\)**

* [https://discord.gg/3qAdjDb](https://discord.gg/3qAdjDb) 

## Official Articles

**Framework articles:**

* [http://www.sebaslab.com/introducing-svelto-ecs-2-9/](http://www.sebaslab.com/introducing-svelto-ecs-2-9/)  \(shows what's changed since 2.8\)
* [http://www.sebaslab.com/introducing-svelto-ecs-2-8/](http://www.sebaslab.com/introducing-svelto-ecs-2-8/)  \(shows what's changed since 2.7\)
* [http://www.sebaslab.com/svelto-2-7-whats-new-and-best-practices/](http://www.sebaslab.com/svelto-2-7-whats-new-and-best-practices/) \(shows what's changed since 2.5\)
* [http://www.sebaslab.com/svelto-ecs-2-5-and-allocation-0-code/](http://www.sebaslab.com/svelto-ecs-2-5-and-allocation-0-code/) \(shows what's changed since 2.0\)
* [http://www.sebaslab.com/svelto-ecs-2-0-almost-production-ready/](http://www.sebaslab.com/svelto-ecs-2-0-almost-production-ready/) \(shows what's changed since 1.0\)
* [http://www.sebaslab.com/ecs-1-0/](http://www.sebaslab.com/ecs-1-0/)
* [http://www.sebaslab.com/learning-svelto-ecs-by-example-the-unity-survival-example/](http://www.sebaslab.com/learning-svelto-ecs-by-example-the-unity-survival-example/)
* [http://www.sebaslab.com/learning-svelto-ecs-by-example-the-vanilla-example/](http://www.sebaslab.com/learning-svelto-ecs-by-example-the-vanilla-example/)
* [http://www.sebaslab.com/svelto-ecs-svelto-tasks-to-write-data-oriented-cache-friendly-multi-threaded-code-in-unity/](http://www.sebaslab.com/svelto-ecs-svelto-tasks-to-write-data-oriented-cache-friendly-multi-threaded-code-in-unity/)

**Theory related articles \(in order of publishing date\):**

* [http://www.sebaslab.com/ioc-container-for-unity3d-part-1/](http://www.sebaslab.com/ioc-container-for-unity3d-part-1/)
* [http://www.sebaslab.com/ioc-container-for-unity3d-part-2/](http://www.sebaslab.com/ioc-container-for-unity3d-part-2/)
* [http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-i-dependency-injection/](http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-i-dependency-injection/)
* [http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-ii-inversion-of-control/](http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-ii-inversion-of-control/)
* [http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-iii-entity-component-systems/](http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-iii-entity-component-systems/)
* [http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-iv-dependency-inversion-principle/](http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-iv-dependency-inversion-principle/)
* [http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-v-drifting-away-from-ioc-containers/](http://www.sebaslab.com/the-truth-behind-inversion-of-control-part-v-drifting-away-from-ioc-containers/)
* [http://www.sebaslab.com/the-quest-for-maintainable-code-and-the-path-to-ecs/](http://www.sebaslab.com/the-quest-for-maintainable-code-and-the-path-to-ecs/)

Note: I included the IoC articles just to show how I shifted over the years from using an IoC container to use an ECS framework and the rationale behind its adoption.

**The perfect companion for Svelto.ECS is Svelto.Tasks to run the logic of the Systems even on other threads!**

* [https://github.com/sebas77/Svelto.Tasks](https://github.com/sebas77/Svelto.Tasks)

## Users Generated Content \(may use old versions of Svelto and be quite outdated\)

* [https://github.com/grovemaster/Unity3D-Game-App](https://github.com/grovemaster/Unity3D-Game-App)
* [https://github.com/colonelsalt/ZombieDeathBoomECS](https://github.com/colonelsalt/ZombieDeathBoomECS)
* [https://eagergames.wordpress.com/category/ecs/](https://eagergames.wordpress.com/category/ecs/) \(Dario Oliveri\)
* [https://blogs.msdn.microsoft.com/uk\_faculty\_connection/2018/05/08/entity-component-system-in-unity-a-tutorial/](https://blogs.msdn.microsoft.com/uk_faculty_connection/2018/05/08/entity-component-system-in-unity-a-tutorial/) \(Lee Stott\)
* [https://github.com/sebas77/Svelto.ECS.Debugger](https://github.com/sebas77/Svelto.ECS.Debugger) \(work just started\)
* [https://github.com/NED-Studio/LGK.Inspector](https://github.com/NED-Studio/LGK.Inspector) \(probably not working anymore\)

## In case of bugs

Best option is to fork and clone [https://github.com/sebas77/Svelto.ECS.Tests](https://github.com/sebas77/Svelto.ECS.Tests), add a new test to reproduce the problem and request a pull. Then open a github, I come here pretty often :\). Also feel free to contact me on twitter or leave comments on the blog!

## [The Github wiki page](https://github.com/sebas77/Svelto.ECS/wiki)

It needs love and as far as I understood, anyone can edit it. Feel free to do so if you have a good understanding of Svelto! I don't update old articles, while the wiki update is not consistent, so the only way to be sure you get it right is to join our Discord channel and ask questions.

## I like the project, how can I help?

Hey thanks a lot for considering this. You can help in several ways. The simplest is to talk about Svelto.ECS and spread the word, more we are, better it is for the community. Then you can help with the documentation, updating the wiki or writing your own articles. Svelto.ECS has all the features needed to make a game with the ECS pattern, but some areas are lacking: A visual debugger and more unit tests are needed. Other platforms other than Unity could get some love too: Xenko, Godot, monogame, FNA or whatever supports c#. Porting to other languages, expecially c++, would be awesome! Please check the lane dedicated to the community tasks list here: https://github.com/sebas77/Svelto.ECS/projects/1 and let me know if you want to take something on!

## Svelto Framework is used to develop the following products\(\*\):

![Gamecraft](https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/35037633/e05ca4fc6f20f1e6150a6ace1d12fe8cd145fa0d.png)
![Robocraft Infinity](https://i.ytimg.com/vi/m_4fpgHwoBs/maxresdefault.jpg) 
![Cardlife](https://i.ytimg.com/vi/q2jaUZjnNyg/maxresdefault.jpg)

\*if you want your products made with Svelto here, just send me an email or whatever, I'll be super happy to add them.

_**Note: Dear Svelto Users : Although I am committed to help you and write articles as much as I can, I will never be able to keep all the documentation up to date. If you are a happy svelto user and you want to contribute, please feel free to update the github wiki! 🙏👊**_

