using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImpactNowWebApp.Controllers
{
    public class CategoryController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            List<Category> cats = new List<Category>();
            cats.Add(GetCat1());
            cats.Add(GetCat2());
            cats.Add(GetCat3());
            cats.Add(GetCat4());
            cats.Add(GetCat5());
            cats.Add(GetCat6());
            cats.Add(GetCat7());
            cats.Add(GetCat8());
            cats.Add(GetCat9());
            cats.Add(GetCat10());
            cats.Add(GetCat11());
            cats.Add(GetCat12());
            cats.Add(GetCat13());
            cats.Add(GetCat14());
            cats.Add(GetCat15());
            cats.Add(GetCat16());
            cats.Add(GetCat17());

            return Request.CreateResponse(HttpStatusCode.OK, cats, Request.GetConfiguration());
        }

        private Category GetCat1()
        {
            Category c = new Category()
            {
                Name = "No Poverty",
                Num = 1,
                ImageUrl = "images/NoPoverty.png",
                Text =
                    "End poverty in all its forms everywhere. Poverty is more than the lack of income and resources to ensure a sustainable livelihood. Its manifestations include hunger and malnutrition, limited access to education and other basic services, social discrimination and exclusion, as well as the lack of participation in decision-making. Economic growth must be inclusive to provide sustainable jobs and promote equality."
                
            };
            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Eradicate Extreme Poverty",
                HoverText =
                    "By 2030, eradicate extreme poverty for all people everywhere, currently measured as people living on less than $1.25 a day."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Reduce People Living in Poverty",
                HoverText =
                    "By 2030, reduce at least by half the proportion of men, women and children of all ages living in poverty in all its dimensions according to national definitions."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Implement Social Protection for People in Poverty",
                HoverText =
                    "Implement nationally appropriate social protection systems and measures for all, including floors, and by 2030 achieve substantial coverage of the poor and the vulnerable."

            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Increase Resources for People in Poverty",
                HoverText =
                    "By 2030, ensure that all men and women, in particular the poor and the vulnerable, have equal rights to economic resources, as well as access to basic services, ownership and control over land and other forms of 13 property, inheritance, natural resources, appropriate new technology and financial services, including microfinance."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Reduce Exposure to Climate for People in Poverty",
                HoverText =
                    "By 2030, build the resilience of the poor and those in vulnerable situations and reduce their exposure and vulnerability to climate-related extreme events and other economic, social and environmental shocks and disasters."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Enhance Poverty Support in Developing Countries",
                HoverText =
                    "Ensure significant mobilization of resources from a variety of sources, including through enhanced development cooperation, in order to provide adequate and predictable means for developing countries, in particular least developed countries, to implement programs and policies to end poverty in all its dimensions."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Create Poverty Policy Development",
                HoverText =
                    "Create sound policy frameworks at the national, regional and international levels, based on pro-poor and gender-sensitive development strategies, to support accelerated investment in poverty eradication actions."
            });
            return c;
        }
        private Category GetCat2()
        {
            Category c = new Category()
            {
                Name = "Zero Hunger",
                Num = 2,
                ImageUrl = "images/ZeroHunger.png",
                Text = "Achieve food security and improved nutrition and promote sustainable agriculture. Right now, our soils, freshwater, oceans, forests and biodiversity are being rapidly degraded. Climate change is putting even more pressure on the resources we depend on, increasing risks associated with disasters such as droughts and floods. Many rural women and men can no longer make ends meet on their land, forcing them to migrate to cities in search of opportunities. A profound change of the global food and agriculture system is needed if we are to nourish today’s 795 million hungry and the additional 2 billion people expected by 2050."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Improve Access to Nutritious Food",
                HoverText =
                    "By 2030, end hunger and ensure access by all people, in particular the poor and people in vulnerable situations, including infants, to safe, nutritious and sufficient food all year round."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Eradicate Malnutrition",
                HoverText =
                    "By 2030, end all forms of malnutrition, including achieving, by 2025, the internationally agreed targets on stunting and wasting in children under 5 years of age, and address the nutritional needs of adolescent girls, pregnant and lactating women and older persons."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Increase Small-Scale Agriculture",
                HoverText =
                    "By 2030, double the agricultural productivity and incomes of small-scale food producers, in particular women, indigenous peoples, family farmers, pastoralists and fishers, including through secure and equal access to land, other productive resources and inputs, knowledge, financial services, markets and opportunities for value addition and non-farm employment."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Support Food Production Systems",
                HoverText =
                    "By 2030, ensure sustainable food production systems and implement resilient agricultural practices that increase productivity and production, that help maintain ecosystems, that strengthen capacity for adaptation to climate change, extreme weather, drought, flooding and other disasters and that progressively improve land and soil quality."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Maintain Genetic Diversity of Plants, Animals, and other Resources",
                HoverText =
                    "By 2020, maintain the genetic diversity of seeds, cultivated plants, and farmed and domesticated animals and their related wild species, including through soundly managed and diversified seed and plant banks at the national, regional and international levels, and promote access to and fair and equitable sharing of benefits arising from the utilization of genetic resources and associated traditional knowledge, as internationally agreed upon."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Expand Agriculture Production in Developing Countries",
                HoverText =
                    "Increase investment, including through enhanced international cooperation, in rural infrastructure, agricultural research and extension services, technology development and plant and livestock gene banks in order to enhance agricultural productive capacity in developing countries, in particular least developed countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Foster World Agricultural Markets",
                HoverText =
                    "Correct and prevent trade restrictions and distortions in world agricultural markets, including through the parallel elimination of all forms of agricultural export subsidies and all export measures with equivalent effect, in accordance with the mandate of the Doha Development Round."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Limit Food Price Volatility",
                HoverText =
                    "Adopt measures to ensure the proper functioning of food commodity markets and their derivatives and facilitate timely access to market information, including on food reserves, in order to help limit extreme food price volatility."
            });
            
            return c;
        }
        private Category GetCat3()
        {
            Category c = new Category()
            {
                Name = "Good Health and Well-Being",
                Num = 3,
                ImageUrl = "images/GoodHealth.png",
                Text = "Ensure healthy lives and promote well-being for all at all ages, which is essential to sustainable development. Significant strides have been made in increasing life expectancy and reducing some of the common killers associated with child and maternal mortality. Major progress has been made on increasing access to clean water and sanitation, reducing malaria, tuberculosis, polio and the spread of HIV/AIDS. However, many more efforts are needed to fully eradicate a wide range of diseases and address many different persistent and emerging health issues."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Reduce Maternity Mortality Rate",
                HoverText =
                    "By 2030, reduce the global maternal mortality ratio to less than 70 per 100,000 live births."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Lower Newborn and Children Mortality Rate",
                HoverText =
                    "By 2030, end preventable deaths of newborns and children under 5 years of age, with all countries aiming to reduce neonatal mortality to at least as low as 12 per 1,000 live births and under-5 mortality to at least as low as 25 per 1,000 live births."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Eliminate Epidemics",
                HoverText =
                    "By 2030, end the epidemics of AIDS, tuberculosis, malaria and neglected tropical diseases and combat hepatitis, water-borne diseases and other communicable diseases."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Increase Prevention and Treatment for Mental Health",
                HoverText =
                    "By 2030, reduce by one-third premature mortality from non-communicable diseases through prevention and treatment, and promote mental health and well-being."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Strengthen Prevention and Treatment of Substance Abuse",
                HoverText =
                    "Strengthen the prevention and treatment of substance abuse, including narcotic drug abuse and harmful use of alcohol."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Reduce Deaths by Road Accidents",
                HoverText = "By 2020, halve the number of global deaths and injuries from road traffic accidents."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Ensure Access to Reproductive Healthcare Services",
                HoverText = "By 2030, ensure universal access to sexual and reproductive healthcare services, including for family planning, information and education, and the integration of reproductive health into national strategies and programs."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Provide Health Coverage, Medicines, and Vaccines",
                HoverText =
                    "Achieve universal health coverage, including financial risk protection, access to quality essential health-care services, and access to safe, effective, quality and affordable essential medicines and vaccines for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Reduce Contamination and Hazardous Chemicals",
                HoverText = "By 2030, substantially reduce the number of deaths and illnesses from hazardous chemicals and air, water, and soil pollution and contamination."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Advance Tobacco Control",
                HoverText = "Strengthen the implementation of the World Health Organization Framework Convention on Tobacco Control in all countries, as appropriate."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 11,
                Text =  "Expand Vaccine and Medical Research",
                HoverText = "Support the research and development of vaccines and medicines for the communicable and non-communicable diseases that primarily affect developing countries, provide access to affordable essential medicines and vaccines, in accordance with the Doha Declaration on the TRIPS Agreement and Public Health, which affirms the right of developing countries to use to the full the provisions in the Agreement on Trade Related Aspects of Intellectual Property Rights regarding flexibilities to protect public health, and, in particular, provide access to medicines for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 12,
                Text = "Increase Health Workforce in Developing Countries",
                HoverText = "Substantially increase health financing and the recruitment, development, training, and retention of the health workforce in developing countries, especially in least-developed countries and Small Island Developing States."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 13,
                Text = "Boost Capacity for Risk Reduction and Disaster Management",
                HoverText = "Strengthen the capacity of all countries, in particular developing countries, for early warning, risk reduction, and management of national and global health risks."
            });
            
            return c;
        }
        private Category GetCat4()
        {
            Category c = new Category()
            {
                Name = "Quality Education",
                Num = 4,
                ImageUrl = "images/QualityEducation.png",
                Text = "Ensure inclusive and quality education for all and promote lifelong learning. Obtaining a quality education is the foundation to improving people’s lives and sustainable development. Major progress has been made towards increasing access to education at all levels and increasing enrolment rates in schools particularly for women and girls. Basic literacy skills have improved tremendously, yet bolder efforts are needed to make even greater strides for achieving universal education goals. For example, the world has achieved equality in primary education between girls and boys, but few countries have achieved that target at all levels of education."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Ensure Quality Education",
                HoverText = "By 2030, ensure that all girls and boys complete free, equitable, and quality primary and secondary education leading to relevant and Goal-4 effective learning outcomes."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Improve Quality of Early Childhood Development",
                HoverText = "By 2030, ensure that all girls and boys have access to quality early childhood development, care, and preprimary education, so that they are ready for primary education."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Foster Equal Access to Education",
                HoverText = "By 2030, ensure equal access for all women and men to affordable and quality technical, vocational, and tertiary education, including university."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Develop Employment Skills",
                HoverText = "By 2030, substantially increase the number of youth and adults who have relevant skills, including technical and vocational skills, for employment, decent jobs, and entrepreneurship."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Ensure Gender Equality in Education",
                HoverText = "By 2030, eliminate gender disparities in education and ensure equal access to all levels of education and vocational training for the vulnerable, including persons with disabilities, indigenous peoples, and children in vulnerable situations."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Increase Literacy",
                HoverText = "By 2030, ensure that all youth and a substantial proportion of adults, both men and women, achieve literacy and numeracy."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Improve Development Skills",
                HoverText = "By 2030, ensure that all learners acquire the knowledge and skills needed to promote sustainable development, including, among others, through education for sustainable development and sustainable lifestyles, human rights, gender equality, promotion of a culture of peace and non-violence, global citizenship and appreciation of cultural diversity, and of culture’s contribution to sustainable development."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Advance Education Facilities",
                HoverText = "Build and upgrade education facilities that are child, disability, and gender sensitive and provide safe, nonviolent, inclusive, and effective learning environments for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Expand Scholarships to Developing Countries",
                HoverText = "By 2020, substantially expand globally the number of scholarships available to developing countries, in particular least developed countries, Small Island Developing States, and African countries, for enrollment in higher education, including vocational training and information and communications technology, technical, engineering, and scientific programs, in developed countries and other developing countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Increase Qualified Teachers",
                HoverText = "By 2030, substantially increase the supply of qualified teachers, including through international cooperation for teacher training in developing countries, especially least developed countries and Small Island Developing States."
            });

            return c;
        }
        private Category GetCat5()
        {
            Category c = new Category()
            {
                Name = "Gender Equality",
                Num = 5,
                ImageUrl = "images/GenderEquality.png",
                Text = "Achieve gender equality and empower all women and girls. Gender equality is not only a fundamental human right, but also a necessary foundation for a peaceful, prosperous, and sustainable world. Providing women and girls with equal access to education, health care, decent work, and representation in political and economic decision-making processes will fuel sustainable economies and benefit societies and humanity at large."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "End Discrimination",
                HoverText = "End all forms of discrimination against all women and girls everywhere."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Eradicate Violence Against Women",
                HoverText = "Eliminate all forms of violence against all women and girls in the public and private spheres, including trafficking, and sexual and other types of exploitation."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "End Forced Marriage and Female Genital Mutilation",
                HoverText = "Eliminate all harmful practices, such as child, early, and forced marriage and female genital mutilation."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Increase Public Services for Women",
                HoverText = "Recognize and value unpaid care and domestic work through the provision of public services, infrastructure and social protection policies and the promotion of shared responsibility within the household and the family as nationally appropriate."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Promote Female Leadership",
                HoverText = "Ensure women’s full and effective participation and equal opportunities for leadership at all levels of decision making in political, economic, and public life."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Guarantee Access to Reproductive Health and Reproductive Rights",
                HoverText = "Ensure universal access to sexual and reproductive health and reproductive rights, as agreed in accordance with the Program of Action of the International Conference on Population and Development and the Beijing Platform for Action, and the outcome documents of their review conferences."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Foster Equality in Ownership and Resources",
                HoverText = "Undertake reforms to give women equal rights to economic resources, as well as access to ownership and control over land and other forms of property, financial services, inheritance, and natural resources, in accordance with national laws."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Empower Women Through Technology",
                HoverText = "Enhance the use of enabling technology, in particular information and communications technology, to promote the empowerment of women."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Strengthen Equality Policy",
                HoverText = "Adopt and strengthen sound policies and enforceable legislation for the promotion of gender equality and the empowerment of all women and girls at all levels."
            });

            return c;
        }
        private Category GetCat6()
        {
            Category c = new Category()
            {
                Name = "Clean Water and Sanitation",
                Num = 6,
                ImageUrl = "images/CleanWater.png",
                Text = "Ensure access to water and sanitation for all. Water scarcity, poor water quality and inadequate sanitation negatively impact food security, livelihood choices and educational opportunities for poor families across the world. Drought afflicts some of the world’s poorest countries, worsening hunger and malnutrition. By 2050, at least one in four people is likely to live in a country affected by chronic or recurring shortages of fresh water."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Increase Access to Safe Drinking Water",
                HoverText = "By 2030, achieve universal and equitable access to safe and affordable drinking water for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Improve Sanitation and Hygiene",
                HoverText = "By 2030, achieve access to adequate and equitable sanitation and hygiene for all and end open defecation, paying special attention to the needs of women and girls and those in vulnerable situations."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Reduce Water Pollution",
                HoverText = "By 2030, improve water quality by reducing pollution, eliminating dumping and minimizing release of hazardous chemicals and materials, halving the proportion of untreated wastewater and substantially increasing recycling and safe reuse globally"
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Increase Water-Use Efficiency",
                HoverText = "By 2030, substantially increase water-use efficiency across all sectors and ensure sustainable withdrawals and supply of freshwater to address water scarcity, and substantially reduce the number of people suffering from water scarcity."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Implement Water Resource Management",
                HoverText = "By 2030, implement integrated water resources management at all levels, including through trans-boundary cooperation, as appropriate."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Protect Water Ecosystems",
                HoverText = "By 2020, protect and restore water-related ecosystems, including mountains, forests, wetlands, rivers, aquifers, and lakes."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Develop Water Support in Developing Countries",
                HoverText = "By 2030, expand international cooperation and capacity-building support to developing countries in water and sanitation-related activities and programs, including water harvesting, desalination, water efficiency, wastewater treatment, recycling, and reuse technologies."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Strengthen Water Improvement in Local Communities",
                HoverText = "Support and strengthen the participation of local communities in improving water and sanitation management."
            });

            return c;
        }
        private Category GetCat7()
        {
            Category c = new Category()
            {
                Name = "Affordable and Clean Energy",
                Num = 7,
                ImageUrl = "images/Affordable.png",
                Text = "Ensure access to affordable, reliable, sustainable, and modern energy for all. Energy is central to nearly every major challenge and opportunity the world faces today. Be it for jobs, security, climate change, food production or increasing incomes, access to energy for all is essential. Sustainable energy is opportunity – it transforms lives, economies, and the planet."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Ensure Affordable Energy Services",
                HoverText = "By 2030, ensure universal access to affordable, reliable, and modern energy services."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Increase Renewable Energy",
                HoverText = "By 2030, increase substantially the share of renewable energy in the global energy mix."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Improve Energy Efficiency",
                HoverText = "By 2030, double the global rate of improvement in energy efficiency."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Enhance Clean Energy Research and Technology ",
                HoverText = "By 2030, enhance international cooperation to facilitate access to clean energy research and technology, including renewable energy, energy efficiency and advanced and cleaner fossil fuel technology, and promote investment in energy infrastructure and clean energy technology."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Expand Energy Technology in Developing Countries",
                HoverText = "By 2030, expand infrastructure and upgrade technology for supplying modern and sustainable energy services for all in developing countries, in particular least developed countries, Small Island Developing States, and land-locked developing countries, in accordance with their respective programs of support."
            });

            return c;
        }
        private Category GetCat8()
        {
            Category c = new Category()
            {
                Name = "Decent Work and Economic Growth",
                Num = 8,
                ImageUrl = "images/DecentWork.jpeg",
                Text = "Promote inclusive and sustainable economic growth, employment, and decent work for all. A continued lack of decent work opportunities, insufficient investments, and under-consumption, lead to an erosion of the basic social contract underlying democratic societies: that all must share in progress. The creation of quality jobs will remain a major challenge for almost all economies well beyond 2015." +
                        "Sustainable economic growth will require societies to create the conditions that allow people to have quality jobs that stimulate the economy while not harming the environment. Job opportunities and decent working conditions are also required for the whole working age population."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Sustain Economic Growth",
                HoverText = "Sustain per capita economic growth in accordance with national circumstances and, in particular, at least 7 per cent gross domestic product growth per annum in the least developed countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Foster Economic Productivity",
                HoverText = "Achieve higher levels of economic productivity through diversification, technological upgrading and innovation, including through a focus on high-value added and labor-intensive sectors."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Promote Development Policies",
                HoverText = "Promote development-oriented policies that support productive activities, decent job creation, entrepreneurship, creativity and innovation, and encourage the formalization and growth of micro-, small-, and medium-sized enterprises, including through access to financial services."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Improve Economic Growth in Developing Countries",
                HoverText = "Improve progressively, through 2030, global resource efficiency in consumption and production and endeavor to decouple economic growth from environmental degradation, in accordance with the 10-year framework of programs on sustainable consumption and production, with developed countries taking the lead."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Increase Employment",
                HoverText = "By 2030, achieve full and productive employment and decent work for all women and men, including for young people and persons with disabilities, and equal pay for work of equal value."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Reduce Unemployed and Uneducated Youth",
                HoverText = "By 2020, substantially reduce the proportion of youth not in employment, education or training."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Eliminate Forced Labor, Slavery, and Human Trafficking",
                HoverText = "Take immediate and effective measures to eradicate forced labor, end modern slavery and human trafficking, and secure the prohibition and elimination of the worst forms of child labor, including recruitment and use of child soldiers, and by 2025 end child labor in all its forms."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Promote Safe Work Environments",
                HoverText = "Protect labor rights and promote safe and secure working environments for all workers, including migrant workers, in particular women migrants, and those in precarious employment."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Create Sustainable Tourism",
                HoverText = "By 2030, devise and implement policies to promote sustainable tourism that creates jobs and promotes local culture and products."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Strengthen Domestic Financial Institutions",
                HoverText = "Strengthen the capacity of domestic financial institutions to encourage and expand access to banking, insurance and financial services for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 11,
                Text =  "Increase Trade Support for Developing Countries",
                HoverText = "Increase Aid for Trade support for developing countries, in particular least developed countries, including through the Enhanced Integrated Framework for Trade-Related Technical Assistance to Least Developed Countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 12,
                Text = "Advance Youth Employment",
                HoverText = "By 2020, develop and operationalize a global strategy for youth employment and implement the Global Jobs Pact of the International Labor Organization."
            });
            
            return c;
        }
        private Category GetCat9()
        {
            Category c = new Category()
            {
                Name = "Industry, Innovation, and Infrastructure",
                Num = 9,
                ImageUrl = "images/IndustryInnovation.png",
                Text = "Build resilient infrastructure, promote sustainable industrialization, and foster innovation. Inclusive and sustainable industrial development is the primary source of income generation, allows for rapid and sustained increases in living standards for all people, and provides the technological solutions to environmentally sound industrialization. Technological progress is the foundation of efforts to achieve environmental objectives, such as increased resource and energy-efficiency. Without technology and innovation, industrialization will not happen, and without industrialization, development will not happen."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Develop Infrastructure",
                HoverText = "Develop quality, reliable, sustainable and resilient infrastructure, including regional and transborder infrastructure, to support economic development and human well-being, with a focus on affordable and equitable access for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Promote Sustainable Industrialization",
                HoverText = "Promote inclusive and sustainable industrialization and, by 2030, significantly raise industry’s share of employment and gross domestic product, in line with national circumstances, and double its share in least developed countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Expand Industrial Enterprises in Developing Countries",
                HoverText = "Increase the access of small-scale industrial and other enterprises, in particular in developing countries to financial services, including affordable credit, and their integration into value chains and markets."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Increase Resource-Use Efficiency",
                HoverText = "By 2030, upgrade infrastructure and retrofit industries to make them sustainable, with increased resource-use efficiency and greater adoption of clean and environmentally sound technologies and industrial processes, with all countries taking action in accordance with their respective capabilities."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Enhance Research and Technology in Industrial Sector",
                HoverText = "Enhance scientific research, upgrade the technological capabilities of industrial sectors in all countries, in particular developing countries, including, by 2030, encouraging innovation and substantially increasing the number of research and development workers per 1 million people and public and private research and development spending."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Improve Infrastructure in Developing Countries",
                HoverText = "Facilitate sustainable and resilient infrastructure development in developing countries through enhanced financial, technological and technical support to African countries, least developed countries, landlocked developing countries and Small Island Developing States."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Advance Technology Innovation in Developing Countries",
                HoverText = "Support domestic technology development, research and innovation in developing countries, including by ensuring a conducive policy environment for, inter alia, industrial diversification and value addition to commodities."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Provide Access to Internet",
                HoverText = "Significantly increase access to information and communications technology and strive to provide universal and affordable access to the Internet in least developed countries by 2020."
            });

            
            return c;
        }
        private Category GetCat10()
        {
            Category c = new Category()
            {
                Name = "Reduce Inequality",
                Num = 10,
                ImageUrl = "images/ReducedInequalities.png",
                Text = "Reduce inequality within and among countries. While income inequality between countries may have been reduced, inequality within countries has risen. There is growing consensus that economic growth is not sufficient to reduce poverty if it is not inclusive and if it does not involve the three dimensions of sustainable development – economic, social, and environmental. To reduce inequality, policies should be universal in principle paying attention to the needs of disadvantaged and marginalized populations."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Sustain Income Growth",
                HoverText = "Achieve and sustain income growth of the bottom 40 per cent of the population at a rate higher than the national average."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Empower Equality",
                HoverText = "By 2030, empower and promote the social, economic, and political inclusion of all, irrespective of age, sex, disability, race, ethnicity, origin, religion, economic or other status."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Ensure Equal Opportunity",
                HoverText = "Ensure equal opportunity and reduce inequalities of outcome, including by eliminating discriminatory laws, policies and practices and promoting appropriate legislation, policies and action in this regard."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Promote Equality Policies",
                HoverText = "Adopt policies, especially fiscal, wage, and social protection policies, and progressively achieve greater equality."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Improve Global Regulations",
                HoverText = "Improve the regulation and monitoring of global financial markets and institutions and strengthen the implementation of such regulations."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Increase Voice for Developing Countries",
                HoverText = "Ensure enhanced representation and voice for developing countries in decision-making in global international economic and financial institutions in order to deliver more effective, credible, accountable and legitimate institutions."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Facilitate Migration",
                HoverText = "Facilitate orderly, safe, regular, and responsible migration and mobility of people, including through the implementation of planned and well-managed migration policies."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Implement Trade in Developing Countries",
                HoverText = "Implement the principle of special and differential treatment for developing countries, in particular least developed countries, in accordance with World Trade Organization agreements."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Promote Investments in Developing Countries",
                HoverText = "Encourage official development assistance and financial flows, including foreign direct investment, to States where the need is greatest, in particular least developed countries, African countries, Small Island Developing States and landlocked developing countries, in accordance with their national plans and programs."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Reduce Migration Cost",
                HoverText = "By 2030, reduce to less than 3 per cent the transaction costs of migrant remittances and eliminate remittance corridors with costs higher than 5 per cent."
            });
            
            return c;
        }
        private Category GetCat11()
        {
            Category c = new Category()
            {
                Name = "Sustainable Cities and Communities",
                Num = 11,
                ImageUrl = "images/SustainableCities.png",
                Text = "Make cities inclusive, safe, resilient, and sustainable. Many challenges exist to maintaining cities in a way that continues to create jobs and prosperity while not straining land and resources. Common urban challenges include congestion, lack of funds to provide basic services, a shortage of adequate housing and declining infrastructure. The challenges cities face can be overcome in ways that allow them to continue to thrive and grow, while improving resource use and reducing pollution and poverty. The future we want includes cities of opportunities for all, with access to basic services, energy, housing, transportation and more."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Ensure Affordable Housing",
                HoverText = "By 2030, ensure access for all to adequate, safe, and affordable housing, and basic services and to upgrade slums."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Increase Public Transportation",
                HoverText = "By 2030, provide access to safe, affordable, accessible, and sustainable transport systems for all, improving road safety, notably by expanding public transport, with special attention to the needs of those in vulnerable situations, women, children, persons with disabilities, and older persons."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Enhance Urbanization",
                HoverText = "By 2030, enhance inclusive and sustainable urbanization and capacity for participatory, integrated, and sustainable human settlement planning and management in all countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Protect Cultural Heritage",
                HoverText = "Strengthen efforts to protect and safeguard the world’s cultural and natural heritage."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Increase Disaster Relief",
                HoverText = "By 2030, significantly reduce the number of deaths and the number of people affected, and substantially decrease the direct economic losses relative to global gross domestic product caused by disasters, including water-related disasters, with a focus on protecting the poor and people in vulnerable situations."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Reduce Environmental Impact of Cities",
                HoverText = "By 2030, reduce the adverse per capita environmental impact of cities, including by paying special attention to air quality and municipal and other waste management."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Increase Public Spaces",
                HoverText = "By 2030, provide universal access to safe, inclusive and accessible, green and public spaces, in particular for women and children, older persons, and persons with disabilities."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Promote Economic, Social, and Environmental Development Planning",
                HoverText = "Support positive economic, social, and environmental links between urban, peri-urban and rural areas by strengthening national and regional development planning."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Increase Disaster Risk Management",
                HoverText = "By 2020, substantially increase the number of cities and human settlements adopting and implementing integrated policies and plans towards inclusion, resource efficiency, mitigation, and adaptation to climate change, resilience to disasters, and develop and implement, in line with the Sendai Framework for Disaster Risk Reduction 2015-2030, holistic disaster risk management at all levels."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Support Infrastructure in Developing Countries",
                HoverText = "Support least developed countries, including through financial and technical assistance, in building sustainable and resilient buildings utilizing local materials."
            });

            return c;
        }
        private Category GetCat12()
        {
            Category c = new Category()
            {
                Name = "Responsible Consumption and Production",
                Num = 12,
                ImageUrl = "images/SustainableCities.png",
                Text = "Ensure sustainable consumption and production patterns. Sustainable consumption and production aims at “doing more and better with less,” increasing net welfare gains from economic activities by reducing resource use, degradation, and pollution along the whole lifecycle, while increasing quality of life. It involves different stakeholders, including business, consumers, policy makers, researchers, scientists, retailers, media, and development cooperation agencies, among others. It also requires a systemic approach and cooperation among actors operating in the supply chain, from producer to final consumer. It involves engaging consumers through awareness and education on sustainable consumption and lifestyles, providing consumers with adequate information through standards and labels, and engaging in sustainable public procurement, among others."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Promote Sustainable Consumption and Production",
                HoverText = "Implement the 10-year framework of programs on sustainable consumption and production, all countries taking action, with developed countries taking the lead, taking into account the development and capabilities of developing countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Increase Natural Resources",
                HoverText = "By 2030, achieve the sustainable management and efficient use of natural resources."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Reduce Food Waste",
                HoverText = "By 2030, halve per capita global food waste at the retail and consumer levels, and reduce food losses along production and supply chains, including post-harvest losses."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Reduce Chemicals, Waste, and Pollution",
                HoverText = "By 2020, achieve the environmentally sound management of chemicals and all wastes throughout their life cycle, in accordance with agreed international frameworks, and significantly reduce their release to air, water and soil in order to minimize their adverse impacts on human health and the environment."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Increase Reuse and Recycling",
                HoverText = "By 2030, substantially reduce waste generation through prevention, reduction, recycling, and reuse."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Promote Corporate Sustainability Practices",
                HoverText = "Encourage companies, especially large and transnational companies, to adopt sustainable practices and to integrate sustainability information into their reporting cycle."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Support Sustainability Policy",
                HoverText = "Promote public procurement practices that are sustainable, in accordance with national policies and priorities."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Improve Education",
                HoverText = "By 2030, ensure that people everywhere have the relevant information and awareness for sustainable development and lifestyles in harmony with nature."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Support Sustainability in Developing Countries",
                HoverText = "Support developing countries to strengthen their scientific and technological capacity to move towards more sustainable patterns of consumption and production."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Develop Tourism",
                HoverText = "Develop and implement tools to monitor sustainable development impacts for sustainable tourism that creates jobs and promotes local culture and products."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 11,
                Text =  "Reduce Financial Barriers to Sustainability",
                HoverText = "Rationalize inefficient fossil-fuel subsidies that encourage wasteful consumption by removing market distortions, in accordance with national circumstances, including by restructuring taxation and phasing out those harmful subsidies, where they exist, to reflect their environmental impacts, taking fully into account the specific needs and conditions of developing countries and minimizing the possible adverse impacts on their development in a manner that protects the poor and the affected communities."
            });            
            return c;
        }
        private Category GetCat13()
        {
            Category c = new Category()
            {
                Name = "Climate Action",
                Num = 13,
                ImageUrl = "images/ClimateAction.png",
                Text = "Take urgent action to combat climate change and its impacts. People are experiencing the significant impacts of climate change, which include changing weather patterns, rising sea level, and more extreme weather events. The greenhouse gas emissions from human activities are driving climate change and continue to rise. They are now at their highest levels in history. Without action, the world’s average surface temperature is projected to rise over the 21st century and is likely to surpass 3 degrees Celsius this century—with some areas of the world expected to warm even more. The poorest and most vulnerable people are being affected the most. But climate change is a global challenge that does not respect national borders. Emissions anywhere affect people everywhere. It is an issue that requires solutions that need to be coordinated at the international level and it requires international cooperation to help developing countries move toward a low-carbon economy."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Strengthen Natural Disaster Relief",
                HoverText = "Strengthen resilience and adaptive capacity to climate-related hazards and natural disasters in all countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Implement Climate Change Policy",
                HoverText = "Integrate climate change measures into national policies, strategies, and planning."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Improve Education",
                HoverText = "Improve education, awareness-raising and human and institutional capacity on climate change mitigation, adaptation, impact reduction, and early warning."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Support Developing Countries",
                HoverText = "Implement the commitment undertaken by developed-country parties to the United Nations Framework Convention on Climate Change to a goal of mobilizing jointly $100 billion annually by 2020 from all sources to address the needs of developing countries in the context of meaningful mitigation actions and transparency on implementation, and fully operationalize the Green Climate Fund through its capitalization, as soon as possible."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Develop Climate Change Management",
                HoverText = "Promote mechanisms for raising capacity for effective climate change-related planning and management in least developed countries and Small Island Developing States, including focusing on women, youth, and local and marginalized communities."
            });

            return c;
        }
        private Category GetCat14()
        {
            Category c = new Category()
            {
                Name = "Life Below Water",
                Num = 14,
                ImageUrl = "images/LifeBelowWater.png",
                Text = "Conserve and sustainably use the oceans, seas, and marine resources. Our rainwater, drinking water, weather, climate, coastlines, much of our food, and even the oxygen in the air we breathe, are all ultimately provided and regulated by the sea. Throughout history, oceans and seas have been vital conduits for trade and transportation. Careful management of this essential global resource is a key feature of a sustainable future."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Reduce Marine Pollution",
                HoverText = "By 2025, prevent and significantly reduce marine pollution of all kinds, in particular from land-based activities, including marine debris and nutrient pollution."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Protect Ecosystems",
                HoverText = "By 2020, sustainably manage and protect marine and coastal ecosystems to avoid significant adverse impacts, including by strengthening their resilience, and take action for their restoration in order to achieve healthy and productive oceans."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Reduce Acidification",
                HoverText = "Minimize and address the impacts of ocean acidification, including through enhanced scientific cooperation at all levels."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Regulate Illegal and Destructive Fishing Practices",
                HoverText = "By 2020, effectively regulate harvesting and end overfishing, illegal, unreported and unregulated fishing, and destructive fishing practices, and implement science-based management plans, in order to restore fish stocks in the shortest time feasible, at least to levels that can produce maximum sustainable yield as determined by their biological characteristics."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Increase Marine Conservation",
                HoverText = "By 2020, conserve at least 10 per cent of coastal and marine areas, consistent with national and international law and based on the best available scientific information."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Reduce Fishing Subsidies",
                HoverText = "By 2020, prohibit certain forms of fisheries subsidies which contribute to overcapacity and overfishing, eliminate subsidies that contribute to illegal, unreported and unregulated fishing and refrain from introducing new such subsidies, recognizing that appropriate and effective special and differential treatment for developing and least developed countries should be an integral part of the World Trade Organization fisheries subsidies negotiation."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Advance Tourism and Economic Benefits",
                HoverText = "By 2030, increase the economic benefits to Small Island Developing States and least developed countries from the sustainable use of marine resources, including through sustainable management of fisheries, aquaculture and tourism."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Develop Education",
                HoverText = "Increase scientific knowledge, develop research capacity and transfer marine technology, taking into account the Intergovernmental Oceanographic Commission Criteria and Guidelines on the Transfer of Marine Technology, in order to improve ocean health and to enhance the contribution of marine biodiversity to the development of developing countries, in particular Small Island Developing States and least developed countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Support Local Markets",
                HoverText = "Provide access for small-scale artisanal fishers to marine resources and markets."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Enhance Marine Law",
                HoverText = "Enhance the conservation and sustainable use of oceans and their resources by implementing international law as reflected in UNCLOS, which provides the legal framework for the conservation and sustainable use of oceans and their resources, as recalled in paragraph 158 of The Future We Want."
            });

            return c;
        }
        private Category GetCat15()
        {
            Category c = new Category()
            {
                Name = "Life on Land",
                Num = 15,
                ImageUrl = "images/LifeOnLand.png",
                Text = "Sustainably manage forests, combat desertification, halt and reverse land degradation, halt biodiversity loss. Forests cover 30 percent of the Earth’s surface and, in addition to providing food security and shelter, forests are key to combating climate change, and protecting biodiversity and the homes of the indigenous population. Thirteen million hectares of forests are being lost every year while the persistent degradation of dry lands has led to the desertification of 3.6 billion hectares. Deforestation and desertification – caused by human activities and climate change – pose major challenges to sustainable development and have affected the lives and livelihoods of millions of people in the fight against poverty. Efforts are being made to manage forests and combat desertification."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Increase Ecosystem Conservation",
                HoverText = "By 2020, ensure the conservation, restoration and sustainable use of terrestrial and inland freshwater ecosystems and their services, in particular forests, wetlands, mountains and dry lands, in line with obligations under international agreements."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Manage Forest Sustainability",
                HoverText = "By 2020, promote the implementation of sustainable management of all types of forests, halt deforestation, restore degraded forests, and substantially increase afforestation and reforestation globally."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Combat Desertification",
                HoverText = "By 2030, combat desertification, restore degraded land and soil, including land affected by desertification, drought and floods, and strive to achieve a land degradation-neutral world."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Support Mountain Conservation",
                HoverText = "By 2030, ensure the conservation of mountain ecosystems, including their biodiversity, in order to enhance their capacity to provide benefits that are essential for sustainable development."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Reduce Degradation of Natural Habitats",
                HoverText = "Take urgent and significant action to reduce the degradation of natural habitats, halt the loss of biodiversity and, by 2020, protect and prevent the extinction of threatened species."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Share Equitable Resource Access",
                HoverText = "Promote fair and equitable sharing of the benefits arising from the utilization of genetic resources and promote appropriate access to such resources, as internationally agreed. "
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "End Poaching and Trafficking",
                HoverText = "Take urgent action to end poaching and trafficking of protected species of flora and fauna and address both demand and supply of illegal wildlife products."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Reduce Alien Species",
                HoverText = "By 2020, introduce measures to prevent the introduction and significantly reduce the impact of invasive alien species on land and water ecosystems and control or eradicate the priority species."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Expand Biodiversity",
                HoverText = "By 2020, integrate ecosystem and biodiversity values into national and local planning, development processes, poverty reduction strategies, and accounts."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Grow Financial Resources",
                HoverText = "Mobilize and significantly increase financial resources from all sources to conserve and sustainably use biodiversity and ecosystems."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 11,
                Text = "Mobilize Resources",
                HoverText = "Mobilize significant resources from all sources and at all levels to finance sustainable forest management and provide adequate incentives to developing countries to advance such management, including for conservation and reforestation."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 12,
                Text = "Develop Global Support",
                HoverText = "Enhance global support for efforts to combat poaching and trafficking of protected species, including by increasing the capacity of local communities to pursue sustainable livelihood opportunities."
            });

            return c;
        }
        private Category GetCat16()
        {
            Category c = new Category()
            {
                Name = "Peace Justice and Strong Institutions",
                Num = 16,
                ImageUrl = "images/PeaceAndJustice.png",
                Text = "Promote just, peaceful and inclusive societies. Goal 16 of the Sustainable Development Goals is dedicated to the promotion of peaceful and inclusive societies for sustainable development, the provision of access to justice for all, and building effective, accountable institutions at all levels."
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Reduce Violence",
                HoverText = "Significantly reduce all forms of violence and related death rates everywhere."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "End Abuse and Trafficking",
                HoverText = "End abuse, exploitation, trafficking, and all forms of violence against and torture of children."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Promote International Justice",
                HoverText = "Promote the rule of law at the national and international levels and ensure equal access to justice for all."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Lower Organized Crime",
                HoverText = "By 2030, significantly reduce illicit financial and arms flows, strengthen the recovery and return of stolen assets, and combat all forms of organized crime."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Eradicate Corruption",
                HoverText = "Substantially reduce corruption and bribery in all their forms."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Foster Institutions",
                HoverText = "Develop effective, accountable and transparent institutions at all levels."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Increase Inclusive Decision-Making",
                HoverText = "Ensure responsive, inclusive, participatory, and representative decision-making at all levels."
            });
    
            c.Subs.Add(new SubCategory()
            {
                Num = 8,
                Text = "Strengthen Global Governance in Developing Countries",
                HoverText = "Broaden and strengthen the participation of developing countries in the institutions of global governance."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 9,
                Text = "Provide Legal Identity",
                HoverText = "By 2030, provide legal identity for all, including birth registration."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 10,
                Text = "Protect Fundamental Freedoms",
                HoverText = "Ensure public access to information and protect fundamental freedoms, in accordance with national legislation and international agreements."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 11,
                Text =  "Combat Terrorism",
                HoverText = "Strengthen relevant national institutions, including through international cooperation, for building capacity at all levels, in particular in developing countries, to prevent violence and combat terrorism and crime."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 12,
                Text = "Promote Non-Discriminatory Policy",
                HoverText = "Promote and enforce non-discriminatory laws and policies for sustainable development."
            });

            return c;
        }
        private Category GetCat17()
        {
            Category c = new Category()
            {
                Name = "Partnership for the Goals",
                Num = 17,
                ImageUrl = "images/Partnerships.png",
                Text = "Revitalize the global partnership for sustainable development. Urgent action is needed to mobilize, redirect and unlock the transformative power of trillions of dollars of private resources to deliver on sustainable development objectives. Long-term investments, including foreign direct investment, are needed in critical sectors, especially in developing countries. These include sustainable energy, infrastructure and transport, as well as information and communications technologies. Review and monitoring frameworks, regulations and incentive structures that enable such investments must be retooled to attract investments and reinforce sustainable development. "
            };

            c.Subs.Add(new SubCategory()
            {
                Num = 1,
                Text = "Improve Financial Capabilities for Developing Countries",
                HoverText = "Strengthen domestic resource mobilization, including through international support to developing countries, to improve domestic capacity for tax and other revenue collection." +
                    "Developed countries to implement fully their official development assistance commitments, including the commitment by many developed countries to achieve the target of 0.7 per cent of ODA/GNI to developing countries and 0.15 to 0.20 per cent of ODA/GNI to least developed countries ODA providers are encouraged to consider setting a target to provide at least 0.20 per cent of ODA/GNI to least developed countries. Mobilize additional financial resources for developing countries from multiple sources. Assist developing countries in attaining long-term debt sustainability through coordinated policies aimed at fostering debt financing, debt relief and debt restructuring, as appropriate, and address the external debt of highly indebted poor countries to reduce debt distress. Adopt and implement investment promotion regimes for least developed countries."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 2,
                Text = "Enhance Technology",
                HoverText = "Enhance North-South, South-South, and triangular regional and international cooperation on and access to science, technology, and innovation, and enhance knowledge sharing on mutually agreed terms, including through improved coordination among existing mechanisms, in particular at the United Nations level, and through a global technology facilitation mechanism." +
                    "Promote the development, transfer, dissemination, and diffusion of environmentally sound technologies to developing countries on favorable terms, including on concessional and preferential terms, as mutually agreed upon. Fully operationalize the technology bank and science, technology and innovation, capacity-building mechanism for least developed countries by 2017, and enhance the use of enabling technology, in particular information and communications technology."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 3,
                Text = "Support Capacity Building in Developing Countries",
                HoverText = "Enhance international support for implementing effective and targeted capacity-building in developing countries to support national plans to implement all the sustainable development goals, including through North-South, South-South, and triangular cooperation."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 4,
                Text = "Promote Equal Trade",
                HoverText = "Promote a universal, rules-based, open, non-discriminatory, and equitable multilateral trading system under the World Trade Organization, including through the conclusion of negotiations under its Doha Development Agenda. " +
                    "Significantly increase the exports of developing countries, in particular with a view to doubling the least developed countries’ share of global exports by 2020. Realize timely implementation of duty-free and quota-free market access on a lasting basis for all least developed countries, consistent with World Trade Organization decisions, including by ensuring that preferential rules of origin applicable to imports from least developed countries are transparent and simple, and contribute to facilitating market access."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 5,
                Text = "Expand Policy and Institutional Coherence",
                HoverText = "Enhance global macroeconomic stability, including through policy coordination and policy coherence. Enhance policy coherence for sustainable development. Respect each country’s policy space and leadership to establish and implement policies for poverty eradication and sustainable development."
            });

            c.Subs.Add(new SubCategory()
            {
                Num = 6,
                Text = "Support Multi-Stakeholder Partnerships",
                HoverText = "Enhance the global partnership for sustainable development, complemented by multi-stakeholder partnerships that mobilize and share knowledge, expertise, technology and financial resources, to support the achievement of the sustainable development goals in all countries, in particular developing countries. Encourage and promote effective public, public-private and civil society partnerships, building on the experience and resourcing strategies of partnerships."
            });
            
            c.Subs.Add(new SubCategory()
            {
                Num = 7,
                Text = "Enhance Data Monitoring and Accountability",
                HoverText = "By 2020, enhance capacity-building support to developing countries, including for least developed countries and Small Island Developing States, to increase significantly the availability of high-quality, timely and reliable data disaggregated by income, gender, age, race, ethnicity, migratory status, disability, geographic location and other characteristics relevant in national contexts. By 2030, build on existing initiatives to develop measurements of progress on sustainable development that complement gross domestic product, and support statistical capacity-building in developing countries."
            });
    
            return c;
        }

    }
}


